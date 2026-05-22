using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200001B RID: 27
	public class InfiniteRuntimeClip : RuntimeElement
	{
		// Token: 0x0600032B RID: 811 RVA: 0x00010F84 File Offset: 0x0000F184
		// Note: this type is marked as 'beforefieldinit'.
		static InfiniteRuntimeClip()
		{
			Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "InfiniteRuntimeClip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr);
			InfiniteRuntimeClip.NativeFieldInfoPtr_m_Playable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr, "m_Playable");
			InfiniteRuntimeClip.NativeFieldInfoPtr_kIntervalEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr, "kIntervalEnd");
			InfiniteRuntimeClip.NativeMethodInfoPtr__ctor_Public_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr, 100663856);
			InfiniteRuntimeClip.NativeMethodInfoPtr_get_intervalStart_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr, 100663857);
			InfiniteRuntimeClip.NativeMethodInfoPtr_get_intervalEnd_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr, 100663858);
			InfiniteRuntimeClip.NativeMethodInfoPtr_set_enable_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr, 100663859);
			InfiniteRuntimeClip.NativeMethodInfoPtr_EvaluateAt_Public_Virtual_Void_Double_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr, 100663860);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00011040 File Offset: 0x0000F240
		[CallerCount(0)]
		public unsafe InfiniteRuntimeClip(Playable playable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiniteRuntimeClip.NativeMethodInfoPtr__ctor_Public_Void_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00011088 File Offset: 0x0000F288
		public unsafe override long intervalStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InfiniteRuntimeClip.NativeMethodInfoPtr_get_intervalStart_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600032E RID: 814 RVA: 0x000110D0 File Offset: 0x0000F2D0
		public unsafe override long intervalEnd
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477621, XrefRangeEnd = 477625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InfiniteRuntimeClip.NativeMethodInfoPtr_get_intervalEnd_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000120 RID: 288
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00011118 File Offset: 0x0000F318
		public unsafe override bool enable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477625, XrefRangeEnd = 477632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InfiniteRuntimeClip.NativeMethodInfoPtr_set_enable_Public_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00011164 File Offset: 0x0000F364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477632, XrefRangeEnd = 477638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EvaluateAt(double localTime, FrameData frameData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref localTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InfiniteRuntimeClip.NativeMethodInfoPtr_EvaluateAt_Public_Virtual_Void_Double_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002FF8 File Offset: 0x000011F8
		public InfiniteRuntimeClip(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000332 RID: 818 RVA: 0x000111BC File Offset: 0x0000F3BC
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00003001 File Offset: 0x00001201
		public unsafe Playable m_Playable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiniteRuntimeClip.NativeFieldInfoPtr_m_Playable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiniteRuntimeClip.NativeFieldInfoPtr_m_Playable)) = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000334 RID: 820 RVA: 0x000111E4 File Offset: 0x0000F3E4
		// (set) Token: 0x06000335 RID: 821 RVA: 0x0000301C File Offset: 0x0000121C
		public unsafe static long kIntervalEnd
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(InfiniteRuntimeClip.NativeFieldInfoPtr_kIntervalEnd, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InfiniteRuntimeClip.NativeFieldInfoPtr_kIntervalEnd, (void*)(&value));
			}
		}

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeFieldInfoPtr_m_Playable;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeFieldInfoPtr_kIntervalEnd;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Playable_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_get_intervalStart_Public_Virtual_get_Int64_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_get_intervalEnd_Public_Virtual_get_Int64_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_set_enable_Public_Virtual_set_Void_Boolean_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateAt_Public_Virtual_Void_Double_FrameData_0;
	}
}
