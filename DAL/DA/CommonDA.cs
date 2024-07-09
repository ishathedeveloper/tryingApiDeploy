using DAL.Interface;
using DAL.Modal;
using static DAL.BO.CommonBO;
using static DAL.Modal.AppDbModal;

namespace DAL.DA
{
    public class CommonDA : ICommon
    {
        private readonly AppDbContext dbContext;
        public CommonDA(AppDbContext _db)
        {
            dbContext = _db;
        }

        public ApiResponse manageUserDetails(UserMasterBO userMaster)
        {

            try
            {
                if (userMaster.Id > 0)
                {
                    var users = dbContext.UserMaster.Where(x => x.Id == userMaster.Id).FirstOrDefault();
                    if (users != null)
                    {
                        userMaster.Name = userMaster.Name;
                        userMaster.Email = userMaster.Email;
                        userMaster.Password = userMaster.Password;
                        dbContext.SaveChanges();
                        return new ApiResponse { Message = "Updated Succesfully", Result = userMaster };
                    }


                }
                else
                {
                    UserMaster users = new UserMaster();
                    users.Name = userMaster.Name;
                    users.Email = userMaster.Email;
                    users.Password = userMaster.Password;
                    dbContext.Add(users);
                    dbContext.SaveChanges();
                    return new ApiResponse { Message = "Added Succesfully", Result = userMaster };
                }

                return new ApiResponse { Message = "Error" };

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public ApiResponse getAllUsers()
        {
            try
            {
                var result = dbContext.UserMaster.ToList();
                if (result != null)
                {
                    return new ApiResponse { Message = "OK", Result = result };
                }
                return new ApiResponse { Message = "Error" };
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
