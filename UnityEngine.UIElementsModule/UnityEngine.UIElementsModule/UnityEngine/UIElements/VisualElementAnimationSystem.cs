using System;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;
using UnityEngine.UIElements.Experimental;

namespace UnityEngine.UIElements
{
	// Token: 0x02000069 RID: 105
	public class VisualElementAnimationSystem : BaseVisualTreeUpdater
	{
		// Token: 0x060002AF RID: 687 RVA: 0x0000A244 File Offset: 0x00008444
		public long CurrentTimeMs()
		{
			return Panel.TimeSinceStartupMs();
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00003E7E File Offset: 0x0000207E
		public override ProfilerMarker profilerMarker
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00003E8B File Offset: 0x0000208B
		public void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00003E98 File Offset: 0x00002098
		public void UnregisterAnimations(List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00003EA5 File Offset: 0x000020A5
		public void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00003EB2 File Offset: 0x000020B2
		public void RegisterAnimations(List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00003EBF File Offset: 0x000020BF
		public override void Update()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00003ECC File Offset: 0x000020CC
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}
	}
}
