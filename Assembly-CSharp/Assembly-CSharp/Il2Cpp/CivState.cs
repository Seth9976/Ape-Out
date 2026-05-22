using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000A7 RID: 167
	public class CivState : GuardState
	{
		// Token: 0x0600142E RID: 5166 RVA: 0x0006D9A4 File Offset: 0x0006BBA4
		// Note: this type is marked as 'beforefieldinit'.
		static CivState()
		{
			Il2CppClassPointerStore<CivState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CivState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CivState>.NativeClassPtr);
			CivState.NativeFieldInfoPtr_bodRends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CivState>.NativeClassPtr, "bodRends");
			CivState.NativeFieldInfoPtr_armRends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CivState>.NativeClassPtr, "armRends");
			CivState.NativeFieldInfoPtr_legRends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CivState>.NativeClassPtr, "legRends");
			CivState.NativeFieldInfoPtr_bodMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CivState>.NativeClassPtr, "bodMats");
			CivState.NativeFieldInfoPtr_armMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CivState>.NativeClassPtr, "armMats");
			CivState.NativeFieldInfoPtr_legMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CivState>.NativeClassPtr, "legMats");
			CivState.NativeMethodInfoPtr_InitModes_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CivState>.NativeClassPtr, 100665014);
			CivState.NativeMethodInfoPtr_GetSpeeds_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CivState>.NativeClassPtr, 100665015);
			CivState.NativeMethodInfoPtr_GetDesiredMode_Public_Virtual_GuardMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CivState>.NativeClassPtr, 100665016);
			CivState.NativeMethodInfoPtr_Investigate_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CivState>.NativeClassPtr, 100665017);
			CivState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CivState>.NativeClassPtr, 100665018);
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0006DAB0 File Offset: 0x0006BCB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52224, RefRangeEnd = 52225, XrefRangeStart = 52197, XrefRangeEnd = 52224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitModes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CivState.NativeMethodInfoPtr_InitModes_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0006DAEC File Offset: 0x0006BCEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52225, XrefRangeEnd = 52231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetSpeeds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CivState.NativeMethodInfoPtr_GetSpeeds_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0006DB28 File Offset: 0x0006BD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52231, XrefRangeEnd = 52233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GuardMode GetDesiredMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CivState.NativeMethodInfoPtr_GetDesiredMode_Public_Virtual_GuardMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuardMode>(intPtr3) : null;
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0006DB74 File Offset: 0x0006BD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52233, XrefRangeEnd = 52235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Investigate(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CivState.NativeMethodInfoPtr_Investigate_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x0006DBC0 File Offset: 0x0006BDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CivState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CivState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CivState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0000EB79 File Offset: 0x0000CD79
		public CivState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x0006DBFC File Offset: 0x0006BDFC
		// (set) Token: 0x06001436 RID: 5174 RVA: 0x0000EB82 File Offset: 0x0000CD82
		public unsafe Il2CppReferenceArray<Renderer> bodRends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivState.NativeFieldInfoPtr_bodRends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivState.NativeFieldInfoPtr_bodRends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x0006DC2C File Offset: 0x0006BE2C
		// (set) Token: 0x06001438 RID: 5176 RVA: 0x0000EBA1 File Offset: 0x0000CDA1
		public unsafe Il2CppReferenceArray<Renderer> armRends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivState.NativeFieldInfoPtr_armRends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivState.NativeFieldInfoPtr_armRends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x0006DC5C File Offset: 0x0006BE5C
		// (set) Token: 0x0600143A RID: 5178 RVA: 0x0000EBC0 File Offset: 0x0000CDC0
		public unsafe Il2CppReferenceArray<Renderer> legRends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivState.NativeFieldInfoPtr_legRends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivState.NativeFieldInfoPtr_legRends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x0006DC8C File Offset: 0x0006BE8C
		// (set) Token: 0x0600143C RID: 5180 RVA: 0x0000EBDF File Offset: 0x0000CDDF
		public unsafe Il2CppReferenceArray<Material> bodMats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivState.NativeFieldInfoPtr_bodMats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivState.NativeFieldInfoPtr_bodMats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x0006DCBC File Offset: 0x0006BEBC
		// (set) Token: 0x0600143E RID: 5182 RVA: 0x0000EBFE File Offset: 0x0000CDFE
		public unsafe Il2CppReferenceArray<Material> armMats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivState.NativeFieldInfoPtr_armMats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivState.NativeFieldInfoPtr_armMats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x0006DCEC File Offset: 0x0006BEEC
		// (set) Token: 0x06001440 RID: 5184 RVA: 0x0000EC1D File Offset: 0x0000CE1D
		public unsafe Il2CppReferenceArray<Material> legMats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivState.NativeFieldInfoPtr_legMats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivState.NativeFieldInfoPtr_legMats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeFieldInfoPtr_bodRends;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeFieldInfoPtr_armRends;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeFieldInfoPtr_legRends;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeFieldInfoPtr_bodMats;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeFieldInfoPtr_armMats;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeFieldInfoPtr_legMats;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeMethodInfoPtr_InitModes_Public_Virtual_Void_0;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeeds_Public_Virtual_Void_0;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr_GetDesiredMode_Public_Virtual_GuardMode_0;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr_Investigate_Public_Virtual_Void_Vector2_0;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
