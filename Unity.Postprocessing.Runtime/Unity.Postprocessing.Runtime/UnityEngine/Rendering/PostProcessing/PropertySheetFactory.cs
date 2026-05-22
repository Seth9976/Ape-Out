using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000060 RID: 96
	public sealed class PropertySheetFactory : Object
	{
		// Token: 0x0600051A RID: 1306 RVA: 0x000166E0 File Offset: 0x000148E0
		// Note: this type is marked as 'beforefieldinit'.
		static PropertySheetFactory()
		{
			Il2CppClassPointerStore<PropertySheetFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "PropertySheetFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertySheetFactory>.NativeClassPtr);
			PropertySheetFactory.NativeFieldInfoPtr_m_Sheets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertySheetFactory>.NativeClassPtr, "m_Sheets");
			PropertySheetFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySheetFactory>.NativeClassPtr, 100663798);
			PropertySheetFactory.NativeMethodInfoPtr_Get_Public_PropertySheet_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySheetFactory>.NativeClassPtr, 100663799);
			PropertySheetFactory.NativeMethodInfoPtr_Get_Public_PropertySheet_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySheetFactory>.NativeClassPtr, 100663800);
			PropertySheetFactory.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySheetFactory>.NativeClassPtr, 100663801);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00016774 File Offset: 0x00014974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448615, XrefRangeEnd = 448620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertySheetFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertySheetFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySheetFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x000167B0 File Offset: 0x000149B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448620, XrefRangeEnd = 448641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertySheet Get(string shaderName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(shaderName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySheetFactory.NativeMethodInfoPtr_Get_Public_PropertySheet_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertySheet>(intPtr3) : null;
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00016800 File Offset: 0x00014A00
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 448659, RefRangeEnd = 448684, XrefRangeStart = 448641, XrefRangeEnd = 448659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertySheet Get(Shader shader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySheetFactory.NativeMethodInfoPtr_Get_Public_PropertySheet_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertySheet>(intPtr3) : null;
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00016850 File Offset: 0x00014A50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 448702, RefRangeEnd = 448703, XrefRangeStart = 448684, XrefRangeEnd = 448702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySheetFactory.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00004B4A File Offset: 0x00002D4A
		public PropertySheetFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00016884 File Offset: 0x00014A84
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00004B53 File Offset: 0x00002D53
		public unsafe Dictionary<Shader, PropertySheet> m_Sheets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySheetFactory.NativeFieldInfoPtr_m_Sheets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Shader, PropertySheet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySheetFactory.NativeFieldInfoPtr_m_Sheets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeFieldInfoPtr_m_Sheets;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_PropertySheet_String_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_PropertySheet_Shader_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
	}
}
