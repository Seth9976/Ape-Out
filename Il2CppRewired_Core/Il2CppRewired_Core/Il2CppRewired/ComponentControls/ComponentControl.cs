using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppRewired.ComponentControls
{
	// Token: 0x02000039 RID: 57
	[Serializable]
	public class ComponentControl : MonoBehaviour
	{
		// Token: 0x0600045F RID: 1119 RVA: 0x0003E468 File Offset: 0x0003C668
		// Note: this type is marked as 'beforefieldinit'.
		static ComponentControl()
		{
			Il2CppClassPointerStore<ComponentControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls", "ComponentControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr);
			ComponentControl.NativeFieldInfoPtr__controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, "_controller");
			ComponentControl.NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, "cyyBkkdxKBBsyXCzMlRPgcvSIBjT");
			ComponentControl.NativeFieldInfoPtr_THEfHgsAtuGLNfUpwNjCxMmgCgh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, "THEfHgsAtuGLNfUpwNjCxMmgCgh");
			ComponentControl.NativeFieldInfoPtr__lastUpdateFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, "_lastUpdateFrame");
			ComponentControl.NativeMethodInfoPtr_get_hasController_Internal_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664024);
			ComponentControl.NativeMethodInfoPtr_get_initialized_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664025);
			ComponentControl.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664026);
			ComponentControl.NativeMethodInfoPtr_ClearValue_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664027);
			ComponentControl.NativeMethodInfoPtr_fYIhzxNCpYJDQvIMrwLAYKWagoE_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664028);
			ComponentControl.NativeMethodInfoPtr_Awake_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664029);
			ComponentControl.NativeMethodInfoPtr_Start_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664030);
			ComponentControl.NativeMethodInfoPtr_OnEnable_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664031);
			ComponentControl.NativeMethodInfoPtr_OnDisable_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664032);
			ComponentControl.NativeMethodInfoPtr_OnDestroy_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664033);
			ComponentControl.NativeMethodInfoPtr_OnValidate_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664034);
			ComponentControl.NativeMethodInfoPtr_OnCanvasGroupChanged_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664035);
			ComponentControl.NativeMethodInfoPtr_OnTransformParentChanged_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664036);
			ComponentControl.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664037);
			ComponentControl.NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664038);
			ComponentControl.NativeMethodInfoPtr_NFTSnGXuZXafcZHIgcYanOLckXY_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664039);
			ComponentControl.NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664040);
			ComponentControl.NativeMethodInfoPtr_zGattYxZQjWKqrjhMDlccOBNlcP_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664041);
			ComponentControl.NativeMethodInfoPtr_ilLZkNyFIEwkNbOyQNmFFIpMaQo_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664042);
			ComponentControl.NativeMethodInfoPtr_LCmYrwVZzAfLeUiFDvNHaNMWskx_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664043);
			ComponentControl.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664044);
			ComponentControl.NativeMethodInfoPtr_xzNKXjAaJMKaZzoFxoimUjvQRfi_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664045);
			ComponentControl.NativeMethodInfoPtr_AMTvavhAJFMZzkgIlyIMREPyico_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664046);
			ComponentControl.NativeMethodInfoPtr_EHnVWOWUyyXfIcTSuYOqyDKTEht_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664047);
			ComponentControl.NativeMethodInfoPtr_DBFYWWHjbUbhOOLHttYJbPpgbYv_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664048);
			ComponentControl.NativeMethodInfoPtr_yysVefprdKUveBnSwaOsQcnPSKO_Internal_IComponentController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664049);
			ComponentControl.NativeMethodInfoPtr_FindController_Internal_Abstract_Virtual_New_IComponentController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664050);
			ComponentControl.NativeMethodInfoPtr_GetRequiredControllerType_Internal_Abstract_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664051);
			ComponentControl.NativeMethodInfoPtr_fUwYdnGmoTJBzAFuUYUOEIzgTyY_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664052);
			ComponentControl.NativeMethodInfoPtr_addlbLsYdhqtKsbAsBkBewwooiH_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664053);
			ComponentControl.NativeMethodInfoPtr_bJGcSKFfswQsFOMCCKwvAFvSIyET_Private_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664054);
			ComponentControl.NativeMethodInfoPtr_iJzeeVgTFhPQqdRTfUGBACRnMOF_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664055);
			ComponentControl.NativeMethodInfoPtr_abpofSZIUjLeYOfnUmWRwGGKaKU_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, 100664056);
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x0003E77C File Offset: 0x0003C97C
		public unsafe virtual bool hasController
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_get_hasController_Internal_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x0003E7C4 File Offset: 0x0003C9C4
		public unsafe bool initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentControl.NativeMethodInfoPtr_get_initialized_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0003E800 File Offset: 0x0003CA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245341, XrefRangeEnd = 245344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComponentControl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentControl.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0003E83C File Offset: 0x0003CA3C
		[CallerCount(0)]
		public unsafe virtual void ClearValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_ClearValue_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0003E878 File Offset: 0x0003CA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245344, XrefRangeEnd = 245346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void fYIhzxNCpYJDQvIMrwLAYKWagoE()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentControl.NativeMethodInfoPtr_fYIhzxNCpYJDQvIMrwLAYKWagoE_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0003E8AC File Offset: 0x0003CAAC
		[CallerCount(0)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_Awake_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0003E8E8 File Offset: 0x0003CAE8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_Start_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0003E924 File Offset: 0x0003CB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245346, XrefRangeEnd = 245353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_OnEnable_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0003E960 File Offset: 0x0003CB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245353, XrefRangeEnd = 245355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_OnDisable_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0003E99C File Offset: 0x0003CB9C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_OnDestroy_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0003E9D8 File Offset: 0x0003CBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245355, XrefRangeEnd = 245356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_OnValidate_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0003EA14 File Offset: 0x0003CC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245356, XrefRangeEnd = 245357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCanvasGroupChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_OnCanvasGroupChanged_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0003EA50 File Offset: 0x0003CC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_OnTransformParentChanged_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0003EA8C File Offset: 0x0003CC8C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0003EAC8 File Offset: 0x0003CCC8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0003EB04 File Offset: 0x0003CD04
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NFTSnGXuZXafcZHIgcYanOLckXY()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_NFTSnGXuZXafcZHIgcYanOLckXY_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0003EB40 File Offset: 0x0003CD40
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 245361, RefRangeEnd = 245366, XrefRangeStart = 245357, XrefRangeEnd = 245361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool nSRkgireMOAkpBoLMmrDfIispUMG()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0003EB88 File Offset: 0x0003CD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245366, XrefRangeEnd = 245370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void zGattYxZQjWKqrjhMDlccOBNlcP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_zGattYxZQjWKqrjhMDlccOBNlcP_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0003EBC4 File Offset: 0x0003CDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245370, XrefRangeEnd = 245371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ilLZkNyFIEwkNbOyQNmFFIpMaQo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_ilLZkNyFIEwkNbOyQNmFFIpMaQo_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0003EC00 File Offset: 0x0003CE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245371, XrefRangeEnd = 245372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LCmYrwVZzAfLeUiFDvNHaNMWskx()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_LCmYrwVZzAfLeUiFDvNHaNMWskx_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0003EC3C File Offset: 0x0003CE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void VcVpHMiieyhyUeIXveeGUlXtjUXf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0003EC78 File Offset: 0x0003CE78
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void xzNKXjAaJMKaZzoFxoimUjvQRfi()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_xzNKXjAaJMKaZzoFxoimUjvQRfi_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0003ECB4 File Offset: 0x0003CEB4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AMTvavhAJFMZzkgIlyIMREPyico()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_AMTvavhAJFMZzkgIlyIMREPyico_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0003ECF0 File Offset: 0x0003CEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245372, XrefRangeEnd = 245376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EHnVWOWUyyXfIcTSuYOqyDKTEht()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentControl.NativeMethodInfoPtr_EHnVWOWUyyXfIcTSuYOqyDKTEht_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0003ED2C File Offset: 0x0003CF2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 245388, RefRangeEnd = 245390, XrefRangeStart = 245376, XrefRangeEnd = 245388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DBFYWWHjbUbhOOLHttYJbPpgbYv()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentControl.NativeMethodInfoPtr_DBFYWWHjbUbhOOLHttYJbPpgbYv_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0003ED68 File Offset: 0x0003CF68
		[CallerCount(0)]
		public unsafe IComponentController yysVefprdKUveBnSwaOsQcnPSKO()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentControl.NativeMethodInfoPtr_yysVefprdKUveBnSwaOsQcnPSKO_Internal_IComponentController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComponentController>(intPtr3) : null;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0003EDA8 File Offset: 0x0003CFA8
		[CallerCount(0)]
		public unsafe virtual IComponentController FindController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_FindController_Internal_Abstract_Virtual_New_IComponentController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComponentController>(intPtr3) : null;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0003EDF4 File Offset: 0x0003CFF4
		[CallerCount(0)]
		public unsafe virtual Type GetRequiredControllerType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentControl.NativeMethodInfoPtr_GetRequiredControllerType_Internal_Abstract_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0003EE40 File Offset: 0x0003D040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245390, XrefRangeEnd = 245393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator fUwYdnGmoTJBzAFuUYUOEIzgTyY()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentControl.NativeMethodInfoPtr_fUwYdnGmoTJBzAFuUYUOEIzgTyY_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0003EE80 File Offset: 0x0003D080
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 245393, RefRangeEnd = 245396, XrefRangeStart = 245393, XrefRangeEnd = 245393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void addlbLsYdhqtKsbAsBkBewwooiH()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentControl.NativeMethodInfoPtr_addlbLsYdhqtKsbAsBkBewwooiH_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0003EEB4 File Offset: 0x0003D0B4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 245399, RefRangeEnd = 245416, XrefRangeStart = 245396, XrefRangeEnd = 245399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool bJGcSKFfswQsFOMCCKwvAFvSIyET(bool A_1, bool A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentControl.NativeMethodInfoPtr_bJGcSKFfswQsFOMCCKwvAFvSIyET_Private_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0003EF0C File Offset: 0x0003D10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245416, XrefRangeEnd = 245417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void iJzeeVgTFhPQqdRTfUGBACRnMOF()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentControl.NativeMethodInfoPtr_iJzeeVgTFhPQqdRTfUGBACRnMOF_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0003EF40 File Offset: 0x0003D140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245417, XrefRangeEnd = 245422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void abpofSZIUjLeYOfnUmWRwGGKaKU()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentControl.NativeMethodInfoPtr_abpofSZIUjLeYOfnUmWRwGGKaKU_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00003696 File Offset: 0x00001896
		public ComponentControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x0003EF74 File Offset: 0x0003D174
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x0000369F File Offset: 0x0000189F
		public unsafe IComponentController _controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentControl.NativeFieldInfoPtr__controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComponentController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentControl.NativeFieldInfoPtr__controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x0003EFA4 File Offset: 0x0003D1A4
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x000036BE File Offset: 0x000018BE
		public unsafe bool cyyBkkdxKBBsyXCzMlRPgcvSIBjT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentControl.NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentControl.NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT)) = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0003EFCC File Offset: 0x0003D1CC
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x000036D9 File Offset: 0x000018D9
		public unsafe bool THEfHgsAtuGLNfUpwNjCxMmgCgh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentControl.NativeFieldInfoPtr_THEfHgsAtuGLNfUpwNjCxMmgCgh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentControl.NativeFieldInfoPtr_THEfHgsAtuGLNfUpwNjCxMmgCgh)) = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x0003EFF4 File Offset: 0x0003D1F4
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x000036F4 File Offset: 0x000018F4
		public unsafe int _lastUpdateFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentControl.NativeFieldInfoPtr__lastUpdateFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentControl.NativeFieldInfoPtr__lastUpdateFrame)) = value;
			}
		}

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeFieldInfoPtr__controller;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeFieldInfoPtr_THEfHgsAtuGLNfUpwNjCxMmgCgh;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeFieldInfoPtr__lastUpdateFrame;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_get_hasController_Internal_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_get_initialized_Internal_get_Boolean_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_ClearValue_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_fYIhzxNCpYJDQvIMrwLAYKWagoE_Private_Virtual_Final_New_Void_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Internal_Virtual_New_Void_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_Start_Internal_Virtual_New_Void_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Internal_Virtual_New_Void_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Internal_Virtual_New_Void_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Internal_Virtual_New_Void_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Internal_Virtual_New_Void_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasGroupChanged_Internal_Virtual_New_Void_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Internal_Virtual_New_Void_0;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Internal_Virtual_New_Void_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_NFTSnGXuZXafcZHIgcYanOLckXY_Internal_Virtual_New_Void_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_New_Boolean_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr_zGattYxZQjWKqrjhMDlccOBNlcP_Internal_Virtual_New_Void_0;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr_ilLZkNyFIEwkNbOyQNmFFIpMaQo_Internal_Virtual_New_Void_0;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr_LCmYrwVZzAfLeUiFDvNHaNMWskx_Internal_Virtual_New_Void_0;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Internal_Virtual_New_Void_0;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_xzNKXjAaJMKaZzoFxoimUjvQRfi_Internal_Virtual_New_Void_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_AMTvavhAJFMZzkgIlyIMREPyico_Internal_Virtual_New_Void_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_EHnVWOWUyyXfIcTSuYOqyDKTEht_Internal_Boolean_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_DBFYWWHjbUbhOOLHttYJbPpgbYv_Internal_Boolean_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_yysVefprdKUveBnSwaOsQcnPSKO_Internal_IComponentController_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_FindController_Internal_Abstract_Virtual_New_IComponentController_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredControllerType_Internal_Abstract_Virtual_New_Type_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_fUwYdnGmoTJBzAFuUYUOEIzgTyY_Private_IEnumerator_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_addlbLsYdhqtKsbAsBkBewwooiH_Private_Void_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_bJGcSKFfswQsFOMCCKwvAFvSIyET_Private_Boolean_Boolean_Boolean_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_iJzeeVgTFhPQqdRTfUGBACRnMOF_Private_Void_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_abpofSZIUjLeYOfnUmWRwGGKaKU_Private_Void_0;

		// Token: 0x02000238 RID: 568
		public sealed class ODIzpUjEMfkuwMKCncXGFCfHKVgB : global::Il2CppSystem.Object
		{
			// Token: 0x0600388D RID: 14477 RVA: 0x00115188 File Offset: 0x00113388
			// Note: this type is marked as 'beforefieldinit'.
			static ODIzpUjEMfkuwMKCncXGFCfHKVgB()
			{
				Il2CppClassPointerStore<ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComponentControl>.NativeClassPtr, "ODIzpUjEMfkuwMKCncXGFCfHKVgB");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB>.NativeClassPtr);
				ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB>.NativeClassPtr, 100664057);
				ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB>.NativeClassPtr, 100664058);
				ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB>.NativeClassPtr, 100664059);
				ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB>.NativeClassPtr, 100664060);
				ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB>.NativeClassPtr, 100664061);
				ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB>.NativeClassPtr, 100664062);
			}

			// Token: 0x0600388E RID: 14478 RVA: 0x00115268 File Offset: 0x00113468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245332, XrefRangeEnd = 245336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170010E3 RID: 4323
			// (get) Token: 0x0600388F RID: 14479 RVA: 0x001152A4 File Offset: 0x001134A4
			public unsafe global::Il2CppSystem.Object lGWADsAPVgBuVCpEAGGxMFmASVGL
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003890 RID: 14480 RVA: 0x001152E4 File Offset: 0x001134E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245336, XrefRangeEnd = 245341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003891 RID: 14481 RVA: 0x00115318 File Offset: 0x00113518
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170010E4 RID: 4324
			// (get) Token: 0x06003892 RID: 14482 RVA: 0x0011534C File Offset: 0x0011354C
			public unsafe global::Il2CppSystem.Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003893 RID: 14483 RVA: 0x0011538C File Offset: 0x0011358C
			[CallerCount(0)]
			public unsafe ODIzpUjEMfkuwMKCncXGFCfHKVgB(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003894 RID: 14484 RVA: 0x00013976 File Offset: 0x00011B76
			public ODIzpUjEMfkuwMKCncXGFCfHKVgB(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010E0 RID: 4320
			// (get) Token: 0x06003895 RID: 14485 RVA: 0x001153D4 File Offset: 0x001135D4
			// (set) Token: 0x06003896 RID: 14486 RVA: 0x0001397F File Offset: 0x00011B7F
			public unsafe global::Il2CppSystem.Object NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010E1 RID: 4321
			// (get) Token: 0x06003897 RID: 14487 RVA: 0x00115404 File Offset: 0x00113604
			// (set) Token: 0x06003898 RID: 14488 RVA: 0x0001399E File Offset: 0x00011B9E
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x170010E2 RID: 4322
			// (get) Token: 0x06003899 RID: 14489 RVA: 0x0011542C File Offset: 0x0011362C
			// (set) Token: 0x0600389A RID: 14490 RVA: 0x000139B9 File Offset: 0x00011BB9
			public unsafe ComponentControl HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComponentControl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentControl.ODIzpUjEMfkuwMKCncXGFCfHKVgB.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002F9C RID: 12188
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x04002F9D RID: 12189
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x04002F9E RID: 12190
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x04002F9F RID: 12191
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002FA0 RID: 12192
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002FA1 RID: 12193
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002FA2 RID: 12194
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002FA3 RID: 12195
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002FA4 RID: 12196
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}
	}
}
