using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x02000077 RID: 119
	public class VisualTreeBindingsUpdater : BaseVisualTreeHierarchyTrackerUpdater
	{
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00004166 File Offset: 0x00002366
		public override ProfilerMarker profilerMarker
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x00004173 File Offset: 0x00002373
		// (set) Token: 0x060002EA RID: 746 RVA: 0x00004180 File Offset: 0x00002380
		public static bool disableBindingsThrottling
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

		// Token: 0x060002EB RID: 747 RVA: 0x0000A27C File Offset: 0x0000847C
		public IBinding GetBindingObjectFromElement(VisualElement ve)
		{
			IBindable bindable = ve.TryCast<IBindable>();
			bool flag = bindable != null;
			if (flag)
			{
				bool flag2 = bindable.binding != null;
				if (flag2)
				{
					return bindable.binding;
				}
			}
			return VisualTreeBindingsUpdater.GetAdditionalBinding(ve);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000418D File Offset: 0x0000238D
		public void StartTracking(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000419A File Offset: 0x0000239A
		public void StopTracking(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002EE RID: 750 RVA: 0x000041A7 File Offset: 0x000023A7
		// (set) Token: 0x060002EF RID: 751 RVA: 0x000041B4 File Offset: 0x000023B4
		public Dictionary<Object, Object> temporaryObjectCache
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

		// Token: 0x060002F0 RID: 752 RVA: 0x000041C1 File Offset: 0x000023C1
		public static void SetAdditionalBinding(VisualElement ve, IBinding b)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000041CE File Offset: 0x000023CE
		public static void ClearAdditionalBinding(VisualElement ve)
		{
			VisualTreeBindingsUpdater.SetAdditionalBinding(ve, null);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x000041D9 File Offset: 0x000023D9
		public static IBinding GetAdditionalBinding(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000041E6 File Offset: 0x000023E6
		public static void AddBindingRequest(VisualElement ve, IBindingRequest req)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000041F3 File Offset: 0x000023F3
		public static void RemoveBindingRequest(VisualElement ve, IBindingRequest req)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00004200 File Offset: 0x00002400
		public static void ClearBindingRequests(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000420D File Offset: 0x0000240D
		public void StartTrackingRecursive(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000421A File Offset: 0x0000241A
		public void StopTrackingRecursive(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00004227 File Offset: 0x00002427
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000A2BC File Offset: 0x000084BC
		public override void OnHierarchyChange(VisualElement ve, HierarchyChangeType type)
		{
			if (type != HierarchyChangeType.Add)
			{
				if (type == HierarchyChangeType.Remove)
				{
					this.StopTrackingRecursive(ve);
				}
			}
			else
			{
				this.StartTrackingRecursive(ve);
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000A2F0 File Offset: 0x000084F0
		public static long CurrentTime()
		{
			return Panel.TimeSinceStartupMs();
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000A308 File Offset: 0x00008508
		public static bool ShouldThrottle(long startTime)
		{
			return !VisualTreeBindingsUpdater.disableBindingsThrottling && VisualTreeBindingsUpdater.CurrentTime() - startTime < 100L;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00004234 File Offset: 0x00002434
		public void PerformTrackingOperations()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00004241 File Offset: 0x00002441
		public override void Update()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000424E File Offset: 0x0000244E
		public void UpdateBindings()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000093 RID: 147
		public const int k_MinUpdateDelayMs = 100;

		// Token: 0x04000094 RID: 148
		public const int k_MaxBindingTimeMs = 100;

		// Token: 0x020001C8 RID: 456
		public class RequestObjectListPool : ObjectListPool<IBindingRequest>
		{
		}
	}
}
