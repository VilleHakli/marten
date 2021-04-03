using System.Collections.Generic;
using Marten.Events.Projections;
using Marten.Storage;

namespace Marten.Events.Aggregation
{
    public interface IEventSlicer<TDoc, TId>
    {
        IReadOnlyList<EventSlice<TDoc, TId>> Slice(IQuerySession querySession, IEnumerable<StreamAction> streams, ITenancy tenancy);
        IReadOnlyList<TenantSliceGroup<TDoc, TId>> Slice(IQuerySession querySession, IReadOnlyList<IEvent> events, ITenancy tenancy);
    }
}
