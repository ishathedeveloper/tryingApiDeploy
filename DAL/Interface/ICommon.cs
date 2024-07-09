using static DAL.BO.CommonBO;

namespace DAL.Interface
{
    public interface ICommon
    {

        ApiResponse manageUserDetails(UserMasterBO userMaster);

        ApiResponse getAllUsers();
    }
}
