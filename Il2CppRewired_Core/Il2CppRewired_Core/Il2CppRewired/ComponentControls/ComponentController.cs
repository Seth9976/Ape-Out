using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppRewired.ComponentControls
{
	// Token: 0x0200003C RID: 60
	[Serializable]
	public class ComponentController : MonoBehaviour
	{
		// Token: 0x06000491 RID: 1169 RVA: 0x0003F214 File Offset: 0x0003D414
		// Note: this type is marked as 'beforefieldinit'.
		static ComponentController()
		{
			Il2CppClassPointerStore<ComponentController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls", "ComponentController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComponentController>.NativeClassPtr);
			ComponentController.NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, "cyyBkkdxKBBsyXCzMlRPgcvSIBjT");
			ComponentController.NativeFieldInfoPtr_THEfHgsAtuGLNfUpwNjCxMmgCgh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, "THEfHgsAtuGLNfUpwNjCxMmgCgh");
			ComponentController.NativeFieldInfoPtr__controls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, "_controls");
			ComponentController.NativeMethodInfoPtr_get_initialized_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, 100664066);
			ComponentController.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, 100664067);
			ComponentController.NativeMethodInfoPtr_Awake_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, 100664068);
			ComponentController.NativeMethodInfoPtr_Update_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, 100664069);
			ComponentController.NativeMethodInfoPtr_OnEnable_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, 100664070);
			ComponentController.NativeMethodInfoPtr_OnDisable_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, 100664071);
			ComponentController.NativeMethodInfoPtr_OnValidate_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, 100664072);
			ComponentController.NativeMethodInfoPtr_OnDestroy_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, 100664073);
			ComponentController.NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, 100664074);
			ComponentController.NativeMethodInfoPtr_ilLZkNyFIEwkNbOyQNmFFIpMaQo_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, 100664075);
			ComponentController.NativeMethodInfoPtr_LCmYrwVZzAfLeUiFDvNHaNMWskx_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, 100664076);
			ComponentController.NativeMethodInfoPtr_UOAZrCtciyyBKiimSIYhuSbRKWy_Private_Virtual_Final_New_Void_IComponentControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, 100664077);
			ComponentController.NativeMethodInfoPtr_lNjjLBZEkWhsSxKmPRADAuTOUvj_Private_Virtual_Final_New_Void_IComponentControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, 100664078);
			ComponentController.NativeMethodInfoPtr_ClearControlValues_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, 100664079);
			ComponentController.NativeMethodInfoPtr_addlbLsYdhqtKsbAsBkBewwooiH_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, 100664080);
			ComponentController.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, 100664081);
			ComponentController.NativeMethodInfoPtr_didArbrucNoxbZyEmsASrLXaceo_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, 100664082);
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x0003F3D4 File Offset: 0x0003D5D4
		public unsafe bool initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentController.NativeMethodInfoPtr_get_initialized_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0003F410 File Offset: 0x0003D610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245427, XrefRangeEnd = 245438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComponentController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComponentController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentController.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0003F44C File Offset: 0x0003D64C
		[CallerCount(0)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentController.NativeMethodInfoPtr_Awake_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0003F488 File Offset: 0x0003D688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245438, XrefRangeEnd = 245448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentController.NativeMethodInfoPtr_Update_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0003F4C4 File Offset: 0x0003D6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245448, XrefRangeEnd = 245452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentController.NativeMethodInfoPtr_OnEnable_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0003F500 File Offset: 0x0003D700
		[CallerCount(0)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentController.NativeMethodInfoPtr_OnDisable_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0003F53C File Offset: 0x0003D73C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 33858, RefRangeEnd = 33864, XrefRangeStart = 33858, XrefRangeEnd = 33864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentController.NativeMethodInfoPtr_OnValidate_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0003F578 File Offset: 0x0003D778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245452, XrefRangeEnd = 245454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentController.NativeMethodInfoPtr_OnDestroy_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0003F5B4 File Offset: 0x0003D7B4
		[CallerCount(0)]
		public unsafe virtual bool nSRkgireMOAkpBoLMmrDfIispUMG()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentController.NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0003F5FC File Offset: 0x0003D7FC
		[CallerCount(0)]
		public unsafe virtual void ilLZkNyFIEwkNbOyQNmFFIpMaQo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentController.NativeMethodInfoPtr_ilLZkNyFIEwkNbOyQNmFFIpMaQo_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0003F638 File Offset: 0x0003D838
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LCmYrwVZzAfLeUiFDvNHaNMWskx()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentController.NativeMethodInfoPtr_LCmYrwVZzAfLeUiFDvNHaNMWskx_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0003F674 File Offset: 0x0003D874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245454, XrefRangeEnd = 245458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UOAZrCtciyyBKiimSIYhuSbRKWy(IComponentControl A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentController.NativeMethodInfoPtr_UOAZrCtciyyBKiimSIYhuSbRKWy_Private_Virtual_Final_New_Void_IComponentControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0003F6B8 File Offset: 0x0003D8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245458, XrefRangeEnd = 245461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void lNjjLBZEkWhsSxKmPRADAuTOUvj(IComponentControl A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentController.NativeMethodInfoPtr_lNjjLBZEkWhsSxKmPRADAuTOUvj_Private_Virtual_Final_New_Void_IComponentControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0003F6FC File Offset: 0x0003D8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245461, XrefRangeEnd = 245471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearControlValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentController.NativeMethodInfoPtr_ClearControlValues_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0003F738 File Offset: 0x0003D938
		[CallerCount(0)]
		public unsafe void addlbLsYdhqtKsbAsBkBewwooiH()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentController.NativeMethodInfoPtr_addlbLsYdhqtKsbAsBkBewwooiH_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0003F76C File Offset: 0x0003D96C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VcVpHMiieyhyUeIXveeGUlXtjUXf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentController.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0003F7A0 File Offset: 0x0003D9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245471, XrefRangeEnd = 245474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator didArbrucNoxbZyEmsASrLXaceo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentController.NativeMethodInfoPtr_didArbrucNoxbZyEmsASrLXaceo_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00003750 File Offset: 0x00001950
		public ComponentController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x0003F7E0 File Offset: 0x0003D9E0
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x00003759 File Offset: 0x00001959
		public unsafe bool cyyBkkdxKBBsyXCzMlRPgcvSIBjT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentController.NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentController.NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT)) = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x0003F808 File Offset: 0x0003DA08
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00003774 File Offset: 0x00001974
		public unsafe bool THEfHgsAtuGLNfUpwNjCxMmgCgh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentController.NativeFieldInfoPtr_THEfHgsAtuGLNfUpwNjCxMmgCgh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentController.NativeFieldInfoPtr_THEfHgsAtuGLNfUpwNjCxMmgCgh)) = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0003F830 File Offset: 0x0003DA30
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x0000378F File Offset: 0x0000198F
		public unsafe List<IComponentControl> _controls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentController.NativeFieldInfoPtr__controls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IComponentControl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentController.NativeFieldInfoPtr__controls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeFieldInfoPtr_THEfHgsAtuGLNfUpwNjCxMmgCgh;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeFieldInfoPtr__controls;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_get_initialized_Internal_get_Boolean_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Internal_Virtual_New_Void_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_Update_Internal_Virtual_New_Void_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Internal_Virtual_New_Void_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Internal_Virtual_New_Void_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Internal_Virtual_New_Void_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Internal_Virtual_New_Void_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_New_Boolean_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_ilLZkNyFIEwkNbOyQNmFFIpMaQo_Internal_Virtual_New_Void_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_LCmYrwVZzAfLeUiFDvNHaNMWskx_Internal_Virtual_New_Void_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_UOAZrCtciyyBKiimSIYhuSbRKWy_Private_Virtual_Final_New_Void_IComponentControl_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_lNjjLBZEkWhsSxKmPRADAuTOUvj_Private_Virtual_Final_New_Void_IComponentControl_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_ClearControlValues_Public_Virtual_New_Void_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_addlbLsYdhqtKsbAsBkBewwooiH_Private_Void_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_didArbrucNoxbZyEmsASrLXaceo_Private_IEnumerator_0;

		// Token: 0x02000239 RID: 569
		public sealed class GkmOLEMaoDdReCjCPwoxieaVyZA : global::Il2CppSystem.Object
		{
			// Token: 0x0600389B RID: 14491 RVA: 0x0011545C File Offset: 0x0011365C
			// Note: this type is marked as 'beforefieldinit'.
			static GkmOLEMaoDdReCjCPwoxieaVyZA()
			{
				Il2CppClassPointerStore<ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComponentController>.NativeClassPtr, "GkmOLEMaoDdReCjCPwoxieaVyZA");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA>.NativeClassPtr);
				ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA>.NativeClassPtr, 100664083);
				ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA>.NativeClassPtr, 100664084);
				ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA>.NativeClassPtr, 100664085);
				ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA>.NativeClassPtr, 100664086);
				ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA>.NativeClassPtr, 100664087);
				ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA>.NativeClassPtr, 100664088);
			}

			// Token: 0x0600389C RID: 14492 RVA: 0x0011553C File Offset: 0x0011373C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170010E8 RID: 4328
			// (get) Token: 0x0600389D RID: 14493 RVA: 0x00115578 File Offset: 0x00113778
			public unsafe global::Il2CppSystem.Object lGWADsAPVgBuVCpEAGGxMFmASVGL
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600389E RID: 14494 RVA: 0x001155B8 File Offset: 0x001137B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245422, XrefRangeEnd = 245427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600389F RID: 14495 RVA: 0x001155EC File Offset: 0x001137EC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170010E9 RID: 4329
			// (get) Token: 0x060038A0 RID: 14496 RVA: 0x00115620 File Offset: 0x00113820
			public unsafe global::Il2CppSystem.Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060038A1 RID: 14497 RVA: 0x00115660 File Offset: 0x00113860
			[CallerCount(0)]
			public unsafe GkmOLEMaoDdReCjCPwoxieaVyZA(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060038A2 RID: 14498 RVA: 0x000139D8 File Offset: 0x00011BD8
			public GkmOLEMaoDdReCjCPwoxieaVyZA(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010E5 RID: 4325
			// (get) Token: 0x060038A3 RID: 14499 RVA: 0x001156A8 File Offset: 0x001138A8
			// (set) Token: 0x060038A4 RID: 14500 RVA: 0x000139E1 File Offset: 0x00011BE1
			public unsafe global::Il2CppSystem.Object NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010E6 RID: 4326
			// (get) Token: 0x060038A5 RID: 14501 RVA: 0x001156D8 File Offset: 0x001138D8
			// (set) Token: 0x060038A6 RID: 14502 RVA: 0x00013A00 File Offset: 0x00011C00
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x170010E7 RID: 4327
			// (get) Token: 0x060038A7 RID: 14503 RVA: 0x00115700 File Offset: 0x00113900
			// (set) Token: 0x060038A8 RID: 14504 RVA: 0x00013A1B File Offset: 0x00011C1B
			public unsafe ComponentController HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComponentController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentController.GkmOLEMaoDdReCjCPwoxieaVyZA.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002FA5 RID: 12197
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x04002FA6 RID: 12198
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x04002FA7 RID: 12199
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x04002FA8 RID: 12200
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002FA9 RID: 12201
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002FAA RID: 12202
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002FAB RID: 12203
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002FAC RID: 12204
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002FAD RID: 12205
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}
	}
}
