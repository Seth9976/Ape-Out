using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000064 RID: 100
	public class TargetPool : Object
	{
		// Token: 0x0600069A RID: 1690 RVA: 0x00019E50 File Offset: 0x00018050
		// Note: this type is marked as 'beforefieldinit'.
		static TargetPool()
		{
			Il2CppClassPointerStore<TargetPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "TargetPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetPool>.NativeClassPtr);
			TargetPool.NativeFieldInfoPtr_m_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPool>.NativeClassPtr, "m_Pool");
			TargetPool.NativeFieldInfoPtr_m_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPool>.NativeClassPtr, "m_Current");
			TargetPool.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPool>.NativeClassPtr, 100663879);
			TargetPool.NativeMethodInfoPtr_Get_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPool>.NativeClassPtr, 100663880);
			TargetPool.NativeMethodInfoPtr_Get_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPool>.NativeClassPtr, 100663881);
			TargetPool.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPool>.NativeClassPtr, 100663882);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00019EF8 File Offset: 0x000180F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449897, XrefRangeEnd = 449904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetPool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetPool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPool.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00019F34 File Offset: 0x00018134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449904, XrefRangeEnd = 449905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPool.NativeMethodInfoPtr_Get_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00019F70 File Offset: 0x00018170
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 449918, RefRangeEnd = 449932, XrefRangeStart = 449905, XrefRangeEnd = 449918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Get(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPool.NativeMethodInfoPtr_Get_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00019FBC File Offset: 0x000181BC
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPool.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x000054AE File Offset: 0x000036AE
		public TargetPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00019FF0 File Offset: 0x000181F0
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x000054B7 File Offset: 0x000036B7
		public unsafe List<int> m_Pool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPool.NativeFieldInfoPtr_m_Pool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPool.NativeFieldInfoPtr_m_Pool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0001A020 File Offset: 0x00018220
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x000054D6 File Offset: 0x000036D6
		public unsafe int m_Current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPool.NativeFieldInfoPtr_m_Current);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPool.NativeFieldInfoPtr_m_Current)) = value;
			}
		}

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeFieldInfoPtr_m_Pool;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeFieldInfoPtr_m_Current;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_Get_Internal_Int32_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_Get_Private_Int32_Int32_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;
	}
}
