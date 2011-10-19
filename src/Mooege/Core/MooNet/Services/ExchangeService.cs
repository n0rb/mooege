﻿/*
 * Copyright (C) 2011 mooege project
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

using System;
using Google.ProtocolBuffers;
using Mooege.Common;
using Mooege.Net.MooNet;
using bnet.protocol;
using bnet.protocol.exchange;
using bnet.protocol.exchange_object_provider;

namespace Mooege.Core.MooNet.Services
{
    [Service(serviceID: 0x0a, serviceName: "bnet.protocol.exchange.ExchangeService")]
    public class ExchangeService : bnet.protocol.exchange.ExchangeService, IServerService
    {
        private static readonly Logger Logger = LogManager.CreateLogger();
        public MooNetClient Client { get; set; }

        public override void GetConfiguration(IRpcController controller, GetConfigurationRequest request, Action<GetConfigurationResponse> done)
        {
            Logger.Trace("GetConfiguration()");
            //TODO: Figure out what the buyout rules/specialist values are, and if they are related /dustinconrad
            var builder = GetConfigurationResponse.CreateBuilder()
                .AddConfigs(SpecialistConfig.CreateBuilder()
                    .SetSpecialist(1)
                    .AddAuctionDurations(720)
                    .AddAuctionDurations(1440)
                    .AddAuctionDurations(2880)
                    .AddAuctionStartDelays(5)
                    .SetAntiSnipingExtensionDelay(1)
                    .AddCurrencyConfig(CurrencyConfig.CreateBuilder()
                        .SetCurrency("D3_GOLD")
                        .SetTickSize(1)
                        .SetFlatOutbidIncr(1)
                        .SetScaleOutbidIncr(10)
                        .SetMinStartingUnitPrice(5)
                        .SetMaxStartingUnitPrice(4294967295)
                        .SetMaxUnitPrice(4294967295)
                        .SetMaxTotalAmount(281474976710655)
                        .SetBuyoutRule(1))
                    .AddCurrencyConfig(CurrencyConfig.CreateBuilder()
                        .SetCurrency("USD")
                        .SetTickSize(2)
                        .SetFlatOutbidIncr(2)
                        .SetScaleOutbidIncr(10)
                        .SetMinStartingUnitPrice(30)
                        .SetMaxStartingUnitPrice(4294967295)
                        .SetMaxUnitPrice(4294967295)
                        .SetMaxTotalAmount(281474976710655)
                        .SetBuyoutRule(1)))
                .AddConfigs(SpecialistConfig.CreateBuilder()
                    .SetSpecialist(2)
                    .AddAuctionDurations(2880)
                    .AddAuctionDurations(10080)
                    .AddAuctionStartDelays(0)
                    .SetAntiSnipingExtensionDelay(0)
                    .AddCurrencyConfig(CurrencyConfig.CreateBuilder()
                        .SetCurrency("D3_GOLD")
                        .SetTickSize(1)
                        .SetFlatOutbidIncr(1)
                        .SetScaleOutbidIncr(10)
                        .SetMinStartingUnitPrice(5)
                        .SetMaxStartingUnitPrice(4294967295)
                        .SetMaxUnitPrice(4294967295)
                        .SetMaxTotalAmount(281474976710655)
                        .SetBuyoutRule(2))
                    .AddCurrencyConfig(CurrencyConfig.CreateBuilder()
                        .SetCurrency("USD")
                        .SetTickSize(2)
                        .SetFlatOutbidIncr(2)
                        .SetScaleOutbidIncr(10)
                        .SetMinStartingUnitPrice(30)
                        .SetMaxStartingUnitPrice(4294967295)
                        .SetMaxUnitPrice(4294967295)
                        .SetMaxTotalAmount(281474976710655)
                        .SetBuyoutRule(2)));
            done(builder.Build());
        }

        public override void SubscribeOrderStatusChange(IRpcController controller, SubscribeOrderStatusChangeRequest request, Action<NoData> done)
        {
            Logger.Trace("SubscribeOrderStatusChange() Stub");
            var builder = NoData.CreateBuilder();
            done(builder.Build());
        }

        public override void UnsubscribeOrderStatusChange(IRpcController controller, UnsubscribeOrderStatusChangeRequest request, Action<NoData> done)
        {
            Logger.Trace("UnsubscribeOrderStatusChange() Stub");
            var builder = NoData.CreateBuilder();
            done(builder.Build());
        }

        public override void CreateOrderBook(IRpcController controller, CreateOrderBookRequest request, Action<CreateOrderBookResponse> done)
        {
            throw new NotImplementedException();
        }

        public override void PlaceOfferOnOrderBook(IRpcController controller, PlaceOfferOnOrderBookRequest request, Action<PlaceOfferOnOrderBookResponse> done)
        {
            throw new NotImplementedException();
        }

        public override void PlaceOfferCreateOrderBookIfNeeded(IRpcController controller, PlaceOfferCreateOrderBookIfNeededRequest request, Action<PlaceOfferCreateOrderBookIfNeededResponse> done)
        {
            throw new NotImplementedException();
        }

        public override void PlaceBidOnOrderBook(IRpcController controller, PlaceBidOnOrderBookRequest request, Action<PlaceBidOnOrderBookResponse> done)
        {
            throw new NotImplementedException();
        }

        public override void PlaceBidCreateOrderBookIfNeeded(IRpcController controller, PlaceBidCreateOrderBookIfNeededRequest request, Action<PlaceBidCreateOrderBookIfNeededResponse> done)
        {
            throw new NotImplementedException();
        }

        public override void QueryOffersByOrderBook(IRpcController controller, QueryOffersByOrderBookRequest request, Action<QueryOffersByOrderBookResponse> done)
        {
            throw new NotImplementedException();
        }

        public override void QueryBidsByOrderBook(IRpcController controller, QueryBidsByOrderBookRequest request, Action<QueryBidsByOrderBookResponse> done)
        {
            throw new NotImplementedException();
        }

        public override void QueryOffersByAccountForItem(IRpcController controller, QueryOffersByAccountForItemRequest request, Action<QueryOffersByAccountForItemResponse> done)
        {
            throw new NotImplementedException();
        }

        public override void QueryBidsByAccountForItem(IRpcController controller, QueryBidsByAccountForItemRequest request, Action<QueryBidsByAccountForItemResponse> done)
        {
            throw new NotImplementedException();
        }

        public override void QueryOrderBooksSummary(IRpcController controller, QueryOrderBooksSummaryRequest request, Action<QueryOrderBooksSummaryResponse> done)
        {
            throw new NotImplementedException();
        }

        public override void QuerySettlementsByOrderBook(IRpcController controller, QuerySettlementsByOrderBookRequest request, Action<QuerySettlementsByOrderBookResponse> done)
        {
            throw new NotImplementedException();
        }

        public override void ReportAuthorize(IRpcController controller, ReportAuthorizeRequest request, Action<NoData> done)
        {
            throw new NotImplementedException();
        }

        public override void ReportSettle(IRpcController controller, ReportSettleRequest request, Action<NoData> done)
        {
            throw new NotImplementedException();
        }

        public override void ReportCancel(IRpcController controller, ReportCancelRequest request, Action<NoData> done)
        {
            throw new NotImplementedException();
        }

        public override void SubscribeOrderBookStatusChange(IRpcController controller, SubscribeOrderBookStatusChangeRequest request, Action<NoData> done)
        {
            throw new NotImplementedException();
        }

        public override void UnsubscribeOrderBookStatusChange(IRpcController controller, UnsubscribeOrderBookStatusChangeRequest request, Action<NoData> done)
        {
            throw new NotImplementedException();
        }

        public override void GetPaymentMethods(IRpcController controller, GetPaymentMethodsRequest request, Action<GetPaymentMethodsResponse> done)
        {
            throw new NotImplementedException();
        }

        public override void ClaimBidItem(IRpcController controller, ClaimRequest request, Action<NoData> done)
        {
            throw new NotImplementedException();
        }

        public override void ClaimBidMoney(IRpcController controller, ClaimRequest request, Action<NoData> done)
        {
            throw new NotImplementedException();
        }

        public override void ClaimOfferItem(IRpcController controller, ClaimRequest request, Action<NoData> done)
        {
            throw new NotImplementedException();
        }

        public override void ClaimOfferMoney(IRpcController controller, ClaimRequest request, Action<NoData> done)
        {
            throw new NotImplementedException();
        }

        public override void CancelBid(IRpcController controller, CancelRequest request, Action<NoData> done)
        {
            throw new NotImplementedException();
        }

        public override void CancelOffer(IRpcController controller, CancelRequest request, Action<NoData> done)
        {
            throw new NotImplementedException();
        }

        public override void GetBidFeeEstimation(IRpcController controller, GetBidFeeEstimationRequest request, Action<GetFeeEstimationResponse> done)
        {
            throw new NotImplementedException();
        }

        public override void GetOfferFeeEstimation(IRpcController controller, GetOfferFeeEstimationRequest request, Action<GetFeeEstimationResponse> done)
        {
            throw new NotImplementedException();
        }
    }
}
