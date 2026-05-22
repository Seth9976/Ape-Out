using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x02000241 RID: 577
	public class LocalizeDropdown : MonoBehaviour
	{
		// Token: 0x06004481 RID: 17537 RVA: 0x000FE8E0 File Offset: 0x000FCAE0
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizeDropdown()
		{
			Il2CppClassPointerStore<LocalizeDropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "LocalizeDropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizeDropdown>.NativeClassPtr);
			LocalizeDropdown.NativeFieldInfoPtr__Terms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizeDropdown>.NativeClassPtr, "_Terms");
			LocalizeDropdown.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeDropdown>.NativeClassPtr, 100670076);
			LocalizeDropdown.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeDropdown>.NativeClassPtr, 100670077);
			LocalizeDropdown.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeDropdown>.NativeClassPtr, 100670078);
			LocalizeDropdown.NativeMethodInfoPtr_OnLocalize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeDropdown>.NativeClassPtr, 100670079);
			LocalizeDropdown.NativeMethodInfoPtr_FillValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeDropdown>.NativeClassPtr, 100670080);
			LocalizeDropdown.NativeMethodInfoPtr_UpdateLocalization_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeDropdown>.NativeClassPtr, 100670081);
			LocalizeDropdown.NativeMethodInfoPtr_UpdateLocalizationTMPro_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeDropdown>.NativeClassPtr, 100670082);
			LocalizeDropdown.NativeMethodInfoPtr_FillValuesTMPro_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeDropdown>.NativeClassPtr, 100670083);
			LocalizeDropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeDropdown>.NativeClassPtr, 100670084);
		}

		// Token: 0x06004482 RID: 17538 RVA: 0x000FE9D8 File Offset: 0x000FCBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111168, XrefRangeEnd = 111180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeDropdown.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004483 RID: 17539 RVA: 0x000FEA0C File Offset: 0x000FCC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111180, XrefRangeEnd = 111191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeDropdown.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004484 RID: 17540 RVA: 0x000FEA40 File Offset: 0x000FCC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111191, XrefRangeEnd = 111195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeDropdown.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004485 RID: 17541 RVA: 0x000FEA74 File Offset: 0x000FCC74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111220, RefRangeEnd = 111222, XrefRangeStart = 111195, XrefRangeEnd = 111220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeDropdown.NativeMethodInfoPtr_OnLocalize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004486 RID: 17542 RVA: 0x000FEAA8 File Offset: 0x000FCCA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111252, RefRangeEnd = 111253, XrefRangeStart = 111222, XrefRangeEnd = 111252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeDropdown.NativeMethodInfoPtr_FillValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004487 RID: 17543 RVA: 0x000FEADC File Offset: 0x000FCCDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111293, RefRangeEnd = 111294, XrefRangeStart = 111253, XrefRangeEnd = 111293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLocalization()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeDropdown.NativeMethodInfoPtr_UpdateLocalization_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004488 RID: 17544 RVA: 0x000FEB10 File Offset: 0x000FCD10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111332, RefRangeEnd = 111333, XrefRangeStart = 111294, XrefRangeEnd = 111332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLocalizationTMPro()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeDropdown.NativeMethodInfoPtr_UpdateLocalizationTMPro_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004489 RID: 17545 RVA: 0x000FEB44 File Offset: 0x000FCD44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111359, RefRangeEnd = 111360, XrefRangeStart = 111333, XrefRangeEnd = 111359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillValuesTMPro()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeDropdown.NativeMethodInfoPtr_FillValuesTMPro_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600448A RID: 17546 RVA: 0x000FEB78 File Offset: 0x000FCD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111360, XrefRangeEnd = 111369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizeDropdown()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizeDropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeDropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600448B RID: 17547 RVA: 0x000296D8 File Offset: 0x000278D8
		public LocalizeDropdown(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x0600448C RID: 17548 RVA: 0x000FEBB4 File Offset: 0x000FCDB4
		// (set) Token: 0x0600448D RID: 17549 RVA: 0x000296E1 File Offset: 0x000278E1
		public unsafe List<string> _Terms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeDropdown.NativeFieldInfoPtr__Terms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeDropdown.NativeFieldInfoPtr__Terms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A47 RID: 10823
		private static readonly IntPtr NativeFieldInfoPtr__Terms;

		// Token: 0x04002A48 RID: 10824
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04002A49 RID: 10825
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x04002A4A RID: 10826
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04002A4B RID: 10827
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalize_Public_Void_0;

		// Token: 0x04002A4C RID: 10828
		private static readonly IntPtr NativeMethodInfoPtr_FillValues_Private_Void_0;

		// Token: 0x04002A4D RID: 10829
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLocalization_Public_Void_0;

		// Token: 0x04002A4E RID: 10830
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLocalizationTMPro_Public_Void_0;

		// Token: 0x04002A4F RID: 10831
		private static readonly IntPtr NativeMethodInfoPtr_FillValuesTMPro_Private_Void_0;

		// Token: 0x04002A50 RID: 10832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
