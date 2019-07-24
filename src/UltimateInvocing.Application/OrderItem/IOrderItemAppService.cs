﻿using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UltimateInvocing.OrderItem.Dto;

namespace UltimateInvocing.OrderItem
{
    public interface IOrderItemAppService : IApplicationService
    {
        Task<List<OrderItemDto>> GetAll();
        Task Create(OrderItemDto productDto);
        Task Delete(Guid id);
        Task<OrderItemDto> GetById(Guid id);
        Task Update(OrderItemDto productDto);

        Task<List<OrderItemDto>> GetAllByOrderId(Guid orderId);
    }
}