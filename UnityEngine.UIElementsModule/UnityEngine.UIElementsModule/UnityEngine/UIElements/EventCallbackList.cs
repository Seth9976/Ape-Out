using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C3 RID: 195
	public class EventCallbackList
	{
		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x000056D3 File Offset: 0x000038D3
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x000056E0 File Offset: 0x000038E0
		public int trickleDownCallbackCount
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x000056ED File Offset: 0x000038ED
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x000056FA File Offset: 0x000038FA
		public int bubbleUpCallbackCount
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0000BAF8 File Offset: 0x00009CF8
		public bool Contains(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			return this.Find(eventTypeId, callback, phase) != null;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00005707 File Offset: 0x00003907
		public EventCallbackFunctorBase Find(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00005714 File Offset: 0x00003914
		public bool Remove(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00005721 File Offset: 0x00003921
		public void Add(EventCallbackFunctorBase item)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0000572E File Offset: 0x0000392E
		public void AddRange(EventCallbackList list)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x0000573B File Offset: 0x0000393B
		public int Count
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00005748 File Offset: 0x00003948
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x00005755 File Offset: 0x00003955
		public EventCallbackFunctorBase Item
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00005762 File Offset: 0x00003962
		public void Clear()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
