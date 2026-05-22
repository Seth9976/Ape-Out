using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppDG.Tweening.Core
{
	// Token: 0x02000048 RID: 72
	public class ABSSequentiable : Object
	{
		// Token: 0x06000458 RID: 1112 RVA: 0x0001AC70 File Offset: 0x00018E70
		// Note: this type is marked as 'beforefieldinit'.
		static ABSSequentiable()
		{
			Il2CppClassPointerStore<ABSSequentiable>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "ABSSequentiable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ABSSequentiable>.NativeClassPtr);
			ABSSequentiable.NativeFieldInfoPtr_tweenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ABSSequentiable>.NativeClassPtr, "tweenType");
			ABSSequentiable.NativeFieldInfoPtr_sequencedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ABSSequentiable>.NativeClassPtr, "sequencedPosition");
			ABSSequentiable.NativeFieldInfoPtr_sequencedEndPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ABSSequentiable>.NativeClassPtr, "sequencedEndPosition");
			ABSSequentiable.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ABSSequentiable>.NativeClassPtr, "onStart");
			ABSSequentiable.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSSequentiable>.NativeClassPtr, 100664167);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0001AD04 File Offset: 0x00018F04
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ABSSequentiable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ABSSequentiable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ABSSequentiable.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000035B0 File Offset: 0x000017B0
		public ABSSequentiable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x0001AD40 File Offset: 0x00018F40
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x000035B9 File Offset: 0x000017B9
		public unsafe TweenType tweenType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ABSSequentiable.NativeFieldInfoPtr_tweenType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ABSSequentiable.NativeFieldInfoPtr_tweenType)) = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x0001AD68 File Offset: 0x00018F68
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x000035D4 File Offset: 0x000017D4
		public unsafe float sequencedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ABSSequentiable.NativeFieldInfoPtr_sequencedPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ABSSequentiable.NativeFieldInfoPtr_sequencedPosition)) = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x0001AD90 File Offset: 0x00018F90
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x000035EF File Offset: 0x000017EF
		public unsafe float sequencedEndPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ABSSequentiable.NativeFieldInfoPtr_sequencedEndPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ABSSequentiable.NativeFieldInfoPtr_sequencedEndPosition)) = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x0001ADB8 File Offset: 0x00018FB8
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x0000360A File Offset: 0x0000180A
		public unsafe TweenCallback onStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ABSSequentiable.NativeFieldInfoPtr_onStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ABSSequentiable.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeFieldInfoPtr_tweenType;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeFieldInfoPtr_sequencedPosition;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeFieldInfoPtr_sequencedEndPosition;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
