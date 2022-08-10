using AutoMapper;
using EmployeeManagement.Common.ConstantsModels;
using EmployeeManagement.Common.ResultModels;
using EmployeeManagement.Common.VModels;
using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DbModels;
using EmployeeManagment.BusinessEngine.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagment.BusinessEngine.İmplementaion
{
    public class EmployeeLeaveTypeBussinesEngine : IEmployeeLeaveTypeBussinesEngine
    {

        #region Variables
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public EmployeeLeaveTypeBussinesEngine(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion

        #region CustomMethods

        public Result<List<EmployeeLeaveTypeVM>> IEmployeeLeaveTypeBussinesEngine.GetAllEmployeeLeaveTypes()
        {
            var data = _unitOfWork.employeeLeaveTypeRepository.GetAll().ToList();
            #region 1.Yontem
            // if (data != null)
            // {
            //  List<EmployeeLeaveType> returnData = new List<EmployeeLeaveType>();
            //  foreach (var item in data)
            // {
            //  returnData.Add(new EmployeeLeaveType()
            //   {
            //  Id = item.Id,
            //    DataCreated = item.DataCreated,
            //    DefaultDays = item.DefaultDays,
            //    Name = item.Name,
            //  });
            // }
            //     return new Result<List<EmployeeLeaveType>>(true, ResultConstants.RecordFound, returnData);
            // }
            //else
            //return new Result<List<EmployeeLeaveType>>(false, ResultConstants.RecordNotFound); 
            #endregion

            #region 2.Yontem
            var leaveTypes = _mapper.Map<List<EmployeeLeaveType>, List<EmployeeLeaveTypeVM>>(data);
            return new Result<List<EmployeeLeaveTypeVM>>(true, ResultConstants.RecordFound, leaveTypes);
            #endregion
        } 
        #endregion

    }
}
