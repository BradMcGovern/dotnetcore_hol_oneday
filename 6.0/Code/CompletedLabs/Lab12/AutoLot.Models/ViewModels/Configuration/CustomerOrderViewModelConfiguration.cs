// Copyright Information
// ==================================
// AutoLot - AutoLot.Models - CustomerOrderViewModelConfiguration.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2021/11/13
// ==================================

namespace AutoLot.Models.ViewModels.Configuration;

public class CustomerOrderViewModelConfiguration : IEntityTypeConfiguration<CustomerOrderViewModel>
{
    public void Configure(EntityTypeBuilder<CustomerOrderViewModel> builder)
    {
        builder.ToView("CustomerOrderView");
    }
}
