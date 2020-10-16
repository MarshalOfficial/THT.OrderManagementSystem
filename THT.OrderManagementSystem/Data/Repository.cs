using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Data.ODataLinq.Helpers;
using THT.OrderManagementSystem.Data.ModelView;
using THT.OrderManagementSystem.Framework;
namespace THT.OrderManagementSystem.Data
{
    public class Repository
    {
        private PTC_MIS_DBEntities _context;

        public Repository()
        {
            _context = new PTC_MIS_DBEntities(Extension.GetEfConnectionString("Data.MISModel"));
        }

        #region [User]

        public Users GetUser(int userid, string pass)
        {
            return _context.Users.FirstOrDefault(l => l.User_ID == userid && l.User_Password.ToLower() == pass.ToLower());
        }
        #endregion

        #region [Visitor]
        public List<Visitor> GetAllVisitors()
        {
            return _context.Visitor.AsNoTracking().ToList();
        }
        #endregion

        #region [Customer]

        public List<Customer> GetAllCustomers()
        {
            return _context.Customer.AsNoTracking().ToList();
        }
        #endregion

        #region [VisitLog]

        public List<VisitLogEntity> GetAllVisitLog(int? visitorCode, string thesabCode, string memo, DateTime? fromdate,    
            DateTime? todate)
        {
            var filter = "";
            if (visitorCode.HasValue)
            {
                filter += " and vl.VisitorCode = " + visitorCode;
            }
            if (!string.IsNullOrWhiteSpace(thesabCode))
            {
                filter += " and vl.THesabCode = '" + thesabCode + "'";
            }
            if (!string.IsNullOrWhiteSpace(memo))
            {
                filter += " and vl.Memo like '%" + memo + "%'";
            }
            if (fromdate.HasValue)
            {
                
                filter += " and vl.CreateDate >= dbo.todaymiladi('" + Framework.Date.Methods.GregorianToShamshiDateWithSlash(fromdate.Value) + "') + '00:00:00'";
            }
            if (todate.HasValue)
            {
                
                filter += " and vl.CreateDate <= dbo.todaymiladi('" + Framework.Date.Methods.GregorianToShamshiDateWithSlash(todate.Value) + "') + '23:59:59'";
            }
            
            var cmd = $@"
                    SELECT vl.*,v.Visitor_Name [VisitorName],c.TName [CustomerName],dbo.TodayWithTime(vl.CreateDate)[SaveTimeFa],
                                   c.[Address],dm.[MapColor],vr.Title [Result],th.T_Mantaghe [CustomerRegionNo]
                    FROM [TOrder].[VisitLog](nolock) vl
                    left join [TOrder].[Visitor](nolock) v on vl.VisitorCode=v.Visitor_Code
                    left join [TOrder].[Customer](nolock) c on vl.THesabCode=c.THesabcode
                    left join [TOrder].[DeviceMap](nolock) dm on vl.VisitorCode=dm.VisitorCode
                    left join [TOrder].[VisitResult](nolock) vr on vl.ResultID=vr.ID
					left join tbl_Taraf_Hesab_table(nolock) th on vl.THesabCode=th.t_acc_code
                    Where 1=1
                    {filter}        
                    order by vl.ID desc ";
            return _context.Database.SqlQuery<VisitLogEntity>(cmd).ToList();
        }
        #endregion

        #region [ShopScan]
        public List<ShopScanEntity> GetAllShopScan(int? visitorCode, string workingbrands, string memo, DateTime? fromdate, 
            DateTime? todate)   
        {
            var filter = "";
            if (visitorCode.HasValue)
            {
                filter += " and sc.VisitorCode = " + visitorCode;
            }
            if (!string.IsNullOrWhiteSpace(workingbrands))
            {
                filter += " and sc.WorkingBrands = '" + workingbrands + "'";
            }
            if (!string.IsNullOrWhiteSpace(memo))
            {
                filter += " and sc.Memo like '%" + memo + "%'";
            }
            if (fromdate.HasValue)
            {

                filter += " and sc.CreateDate >= dbo.todaymiladi('" + Framework.Date.Methods.GregorianToShamshiDateWithSlash(fromdate.Value) + "') + '00:00:00'";
            }
            if (todate.HasValue)
            {

                filter += " and sc.CreateDate <= dbo.todaymiladi('" + Framework.Date.Methods.GregorianToShamshiDateWithSlash(todate.Value) + "') + '23:59:59'";
            }
            
            var cmd = $@"
                    SELECT sc.*,v.Visitor_Name [VisitorName],dbo.TodayWithTime(sc.CreateDate)[SaveTimeFa],dm.[MapColor]
                      FROM [TOrder].[ShopScan](nolock) sc
                      left join [TOrder].[Visitor](nolock) v on sc.VisitorCode=v.Visitor_Code
                      left join [TOrder].[DeviceMap](nolock) dm on sc.VisitorCode=dm.VisitorCode
                      where 1=1
                      {filter}
                      order by sc.ID desc ";
            return _context.Database.SqlQuery<ShopScanEntity>(cmd).ToList();
        }
        #endregion

        #region [BrandBank]

        public List<BrandBank> GetAllBrandBanks()
        {
            return _context.BrandBank.AsNoTracking().OrderBy(l=>l.Title).ToList();
        }

        public void AddBrandBank(BrandBank obj)
        {
            obj.CreateDate = DateTime.Now;
            _context.BrandBank.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteBrandBank(int id)
        {
            _context.Database.ExecuteSqlCommand($@" delete from [TOrder].[BrandBank] where ID={id} ");
        }

        public BrandBank GetBrandByByName(string name)
        {
            return _context.BrandBank.AsNoTracking().FirstOrDefault(l => l.Title == name);
        }
        #endregion

        #region [Orders]

        public List<InvHeaderEntity> GetAllInvHeaders(int? visitorCode, string thesabCode, string memo, DateTime? fromdate,
            DateTime? todate)
        {
            var filter = "";
            if (visitorCode.HasValue)
            {
                filter += " and o.VisitorCode = " + visitorCode;
            }
            if (!string.IsNullOrWhiteSpace(thesabCode))
            {
                filter += " and o.THesabcode = '" + thesabCode + "'";
            }
            if (!string.IsNullOrWhiteSpace(memo))
            {
                filter += " and o.InvMemo like '%" + memo + "%'";
            }
            if (fromdate.HasValue)
            {

                filter += " and o.VisitOrderSaveDate >= dbo.todaymiladi('" + Framework.Date.Methods.GregorianToShamshiDateWithSlash(fromdate.Value) + "') + '00:00:00'";
            }
            if (todate.HasValue)
            {

                filter += " and o.VisitOrderSaveDate <= dbo.todaymiladi('" + Framework.Date.Methods.GregorianToShamshiDateWithSlash(todate.Value) + "') + '23:59:59'";
            }

            var cmd = $@"
                    SELECT o.*,v.Visitor_Name [VisitorName],c.TName [CustomerName],dbo.TodayWithTime(o.VisitOrderSaveDate)[SaveTimeFa],c.[Address],
                    ( SELECT isnull(sum(((100-isnull(Reduction_p,0))*(isnull(K_Price,0)*isnull(PK_Amount,0)))/100),0) [RowPrice] FROM [TOrder].[InvDetails](nolock) d Where d.[PInv_Code]=o.[PInv_Code])[InvPrice]
                    FROM [TOrder].[InvHeader](nolock) o
                    left join [TOrder].[Visitor](nolock) v on o.VisitorCode=v.Visitor_Code
                    left join [TOrder].[Customer](nolock) c on o.THesabCode=c.THesabcode
                    Where 1=1
                    {filter}        
                    order by o.ID desc ";
            return _context.Database.SqlQuery<InvHeaderEntity>(cmd).ToList();
        }

        public List<InvDetailEntity> GetAllInvDetailsByHeader(string pinvcode)
        {
            var filter = $@" and PInv_Code='{pinvcode}' ";
            var cmd = $@"
                    SELECT *,((100-isnull(Reduction_p,0))*(isnull(K_Price,0)*isnull(PK_Amount,0)))/100 [RowPrice] FROM [TOrder].[InvDetails](nolock)
                    Where 1=1
                    {filter}        
                    order by ID desc ";
            return _context.Database.SqlQuery<InvDetailEntity>(cmd).ToList();
        }
        #endregion

        #region [DeviceMap]

        public List<DeviceMap> GetAllDeviceMap()
        {
            return _context.DeviceMap.AsNoTracking().ToList();
        }

        public DeviceMap GetDeviceMap(int id)
        {
            return _context.DeviceMap.AsNoTracking().FirstOrDefault(l => l.ID == id);
        }

        public void UpdateDeviceMap(DeviceMap obj)
        {
            var query = $@"UPDATE [TOrder].[DeviceMap]
                           SET [TargetValue] = {obj.TargetValue.ToString().Replace("/", ".")}
                              ,[TargetValue1] = {obj.TargetValue1.ToString().Replace("/", ".")}
                              ,[TargetValue2] = {obj.TargetValue2.ToString().Replace("/", ".")}
                              ,[TargetValue3] = {obj.TargetValue3.ToString().Replace("/", ".")}
                              ,[TargetValue4] = {obj.TargetValue4.ToString().Replace("/", ".")}
                              ,[TargetValue5] = {obj.TargetValue5.ToString().Replace("/", ".")}
                              ,[TargetValue6] = {obj.TargetValue6.ToString().Replace("/", ".")}
                              ,[TargetValue7] = {obj.TargetValue7.ToString().Replace("/", ".")}
                              ,[TargetValue8] = {obj.TargetValue8.ToString().Replace("/", ".")}
                              ,[TargetValue9] = {obj.TargetValue9.ToString().Replace("/", ".")}
                              ,[TargetValue10] = {obj.TargetValue10.ToString().Replace("/", ".")}
                              ,[TargetValue11] = {obj.TargetValue11.ToString().Replace("/", ".")}
                              ,[VisitLogCountTarget] = {obj.VisitLogCountTarget}
                              ,[VisitLogCountTarget1] = {obj.VisitLogCountTarget1}
                              ,[VisitLogCountTarget2] = {obj.VisitLogCountTarget2}
                              ,[VisitLogCountTarget3] = {obj.VisitLogCountTarget3}
                              ,[VisitLogCountTarget4] = {obj.VisitLogCountTarget4}
                              ,[VisitLogCountTarget5] = {obj.VisitLogCountTarget5}
                              ,[VisitLogCountTarget6] = {obj.VisitLogCountTarget6}
                              ,[VisitLogCountTarget7] = {obj.VisitLogCountTarget7}
                              ,[VisitLogCountTarget8] = {obj.VisitLogCountTarget8}
                              ,[VisitLogCountTarget9] = {obj.VisitLogCountTarget9}
                              ,[VisitLogCountTarget10] = {obj.VisitLogCountTarget10}
                              ,[VisitLogCountTarget11] = {obj.VisitLogCountTarget11}
                         WHERE ID={obj.ID}
            ";
            _context.Database.ExecuteSqlCommand(query);

        }
        #endregion
    }
}
