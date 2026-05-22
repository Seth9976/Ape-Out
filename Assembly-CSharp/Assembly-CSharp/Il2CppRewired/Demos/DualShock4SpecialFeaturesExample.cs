using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.ControllerExtensions;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppRewired.Demos
{
	// Token: 0x0200020F RID: 527
	public class DualShock4SpecialFeaturesExample : MonoBehaviour
	{
		// Token: 0x0600406E RID: 16494 RVA: 0x000F0DD4 File Offset: 0x000EEFD4
		// Note: this type is marked as 'beforefieldinit'.
		static DualShock4SpecialFeaturesExample()
		{
			Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "DualShock4SpecialFeaturesExample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr);
			DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_maxTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, "maxTouches");
			DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, "playerId");
			DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_touchpadTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, "touchpadTransform");
			DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_lightObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, "lightObject");
			DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_accelerometerTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, "accelerometerTransform");
			DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_touches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, "touches");
			DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_unusedTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, "unusedTouches");
			DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_isFlashing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, "isFlashing");
			DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_textStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, "textStyle");
			DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_get_player_Private_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100669585);
			DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100669586);
			DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100669587);
			DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100669588);
			DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_ResetOrientation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100669589);
			DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_SetRandomLightColor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100669590);
			DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_StartLightFlash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100669591);
			DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_StopLightFlash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100669592);
			DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_GetFirstDS4_Private_IDualShock4Extension_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100669593);
			DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_InitializeTouchObjects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100669594);
			DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_HandleTouchpad_Private_Void_IDualShock4Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100669595);
			DualShock4SpecialFeaturesExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100669596);
		}

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x0600406F RID: 16495 RVA: 0x000F0FA8 File Offset: 0x000EF1A8
		public unsafe Player player
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 103383, RefRangeEnd = 103402, XrefRangeStart = 103377, XrefRangeEnd = 103383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_get_player_Private_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x06004070 RID: 16496 RVA: 0x000F0FE8 File Offset: 0x000EF1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103402, XrefRangeEnd = 103403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004071 RID: 16497 RVA: 0x000F101C File Offset: 0x000EF21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103403, XrefRangeEnd = 103484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004072 RID: 16498 RVA: 0x000F1050 File Offset: 0x000EF250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103484, XrefRangeEnd = 103586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004073 RID: 16499 RVA: 0x000F1084 File Offset: 0x000EF284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103586, XrefRangeEnd = 103591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetOrientation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_ResetOrientation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x000F10B8 File Offset: 0x000EF2B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103608, RefRangeEnd = 103609, XrefRangeStart = 103591, XrefRangeEnd = 103608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRandomLightColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_SetRandomLightColor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004075 RID: 16501 RVA: 0x000F10EC File Offset: 0x000EF2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103609, XrefRangeEnd = 103625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLightFlash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_StartLightFlash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004076 RID: 16502 RVA: 0x000F1120 File Offset: 0x000EF320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103625, XrefRangeEnd = 103639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopLightFlash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_StopLightFlash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004077 RID: 16503 RVA: 0x000F1154 File Offset: 0x000EF354
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 103667, RefRangeEnd = 103676, XrefRangeStart = 103639, XrefRangeEnd = 103667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDualShock4Extension GetFirstDS4(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_GetFirstDS4_Private_IDualShock4Extension_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDualShock4Extension>(intPtr3) : null;
			}
		}

		// Token: 0x06004078 RID: 16504 RVA: 0x000F11A4 File Offset: 0x000EF3A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103715, RefRangeEnd = 103716, XrefRangeStart = 103676, XrefRangeEnd = 103715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeTouchObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_InitializeTouchObjects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004079 RID: 16505 RVA: 0x000F11D8 File Offset: 0x000EF3D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103766, RefRangeEnd = 103767, XrefRangeStart = 103716, XrefRangeEnd = 103766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleTouchpad(IDualShock4Extension ds4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ds4);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_HandleTouchpad_Private_Void_IDualShock4Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600407A RID: 16506 RVA: 0x000F121C File Offset: 0x000EF41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DualShock4SpecialFeaturesExample()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600407B RID: 16507 RVA: 0x0002767F File Offset: 0x0002587F
		public DualShock4SpecialFeaturesExample(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x0600407C RID: 16508 RVA: 0x000F1258 File Offset: 0x000EF458
		// (set) Token: 0x0600407D RID: 16509 RVA: 0x00027688 File Offset: 0x00025888
		public unsafe static int maxTouches
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_maxTouches, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_maxTouches, (void*)(&value));
			}
		}

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x0600407E RID: 16510 RVA: 0x000F1274 File Offset: 0x000EF474
		// (set) Token: 0x0600407F RID: 16511 RVA: 0x00027696 File Offset: 0x00025896
		public unsafe int playerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_playerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_playerId)) = value;
			}
		}

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x06004080 RID: 16512 RVA: 0x000F129C File Offset: 0x000EF49C
		// (set) Token: 0x06004081 RID: 16513 RVA: 0x000276B1 File Offset: 0x000258B1
		public unsafe Transform touchpadTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_touchpadTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_touchpadTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x06004082 RID: 16514 RVA: 0x000F12CC File Offset: 0x000EF4CC
		// (set) Token: 0x06004083 RID: 16515 RVA: 0x000276D0 File Offset: 0x000258D0
		public unsafe GameObject lightObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_lightObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_lightObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x06004084 RID: 16516 RVA: 0x000F12FC File Offset: 0x000EF4FC
		// (set) Token: 0x06004085 RID: 16517 RVA: 0x000276EF File Offset: 0x000258EF
		public unsafe Transform accelerometerTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_accelerometerTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_accelerometerTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x06004086 RID: 16518 RVA: 0x000F132C File Offset: 0x000EF52C
		// (set) Token: 0x06004087 RID: 16519 RVA: 0x0002770E File Offset: 0x0002590E
		public unsafe List<DualShock4SpecialFeaturesExample.Touch> touches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_touches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DualShock4SpecialFeaturesExample.Touch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_touches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x06004088 RID: 16520 RVA: 0x000F135C File Offset: 0x000EF55C
		// (set) Token: 0x06004089 RID: 16521 RVA: 0x0002772D File Offset: 0x0002592D
		public unsafe Queue<DualShock4SpecialFeaturesExample.Touch> unusedTouches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_unusedTouches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<DualShock4SpecialFeaturesExample.Touch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_unusedTouches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x0600408A RID: 16522 RVA: 0x000F138C File Offset: 0x000EF58C
		// (set) Token: 0x0600408B RID: 16523 RVA: 0x0002774C File Offset: 0x0002594C
		public unsafe bool isFlashing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_isFlashing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_isFlashing)) = value;
			}
		}

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x0600408C RID: 16524 RVA: 0x000F13B4 File Offset: 0x000EF5B4
		// (set) Token: 0x0600408D RID: 16525 RVA: 0x00027767 File Offset: 0x00025967
		public unsafe GUIStyle textStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_textStyle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_textStyle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002792 RID: 10130
		private static readonly IntPtr NativeFieldInfoPtr_maxTouches;

		// Token: 0x04002793 RID: 10131
		private static readonly IntPtr NativeFieldInfoPtr_playerId;

		// Token: 0x04002794 RID: 10132
		private static readonly IntPtr NativeFieldInfoPtr_touchpadTransform;

		// Token: 0x04002795 RID: 10133
		private static readonly IntPtr NativeFieldInfoPtr_lightObject;

		// Token: 0x04002796 RID: 10134
		private static readonly IntPtr NativeFieldInfoPtr_accelerometerTransform;

		// Token: 0x04002797 RID: 10135
		private static readonly IntPtr NativeFieldInfoPtr_touches;

		// Token: 0x04002798 RID: 10136
		private static readonly IntPtr NativeFieldInfoPtr_unusedTouches;

		// Token: 0x04002799 RID: 10137
		private static readonly IntPtr NativeFieldInfoPtr_isFlashing;

		// Token: 0x0400279A RID: 10138
		private static readonly IntPtr NativeFieldInfoPtr_textStyle;

		// Token: 0x0400279B RID: 10139
		private static readonly IntPtr NativeMethodInfoPtr_get_player_Private_get_Player_0;

		// Token: 0x0400279C RID: 10140
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400279D RID: 10141
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400279E RID: 10142
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x0400279F RID: 10143
		private static readonly IntPtr NativeMethodInfoPtr_ResetOrientation_Private_Void_0;

		// Token: 0x040027A0 RID: 10144
		private static readonly IntPtr NativeMethodInfoPtr_SetRandomLightColor_Private_Void_0;

		// Token: 0x040027A1 RID: 10145
		private static readonly IntPtr NativeMethodInfoPtr_StartLightFlash_Private_Void_0;

		// Token: 0x040027A2 RID: 10146
		private static readonly IntPtr NativeMethodInfoPtr_StopLightFlash_Private_Void_0;

		// Token: 0x040027A3 RID: 10147
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstDS4_Private_IDualShock4Extension_Player_0;

		// Token: 0x040027A4 RID: 10148
		private static readonly IntPtr NativeMethodInfoPtr_InitializeTouchObjects_Private_Void_0;

		// Token: 0x040027A5 RID: 10149
		private static readonly IntPtr NativeMethodInfoPtr_HandleTouchpad_Private_Void_IDualShock4Extension_0;

		// Token: 0x040027A6 RID: 10150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003A8 RID: 936
		public class Touch : global::Il2CppSystem.Object
		{
			// Token: 0x060058FD RID: 22781 RVA: 0x00142820 File Offset: 0x00140A20
			// Note: this type is marked as 'beforefieldinit'.
			static Touch()
			{
				Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.Touch>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, "Touch");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.Touch>.NativeClassPtr);
				DualShock4SpecialFeaturesExample.Touch.NativeFieldInfoPtr_go = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.Touch>.NativeClassPtr, "go");
				DualShock4SpecialFeaturesExample.Touch.NativeFieldInfoPtr_touchId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.Touch>.NativeClassPtr, "touchId");
				DualShock4SpecialFeaturesExample.Touch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.Touch>.NativeClassPtr, 100669597);
			}

			// Token: 0x060058FE RID: 22782 RVA: 0x00142888 File Offset: 0x00140A88
			[CallerCount(0)]
			public unsafe Touch()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.Touch>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.Touch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058FF RID: 22783 RVA: 0x00032F73 File Offset: 0x00031173
			public Touch(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002089 RID: 8329
			// (get) Token: 0x06005900 RID: 22784 RVA: 0x001428C4 File Offset: 0x00140AC4
			// (set) Token: 0x06005901 RID: 22785 RVA: 0x00032F7C File Offset: 0x0003117C
			public unsafe GameObject go
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.Touch.NativeFieldInfoPtr_go);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.Touch.NativeFieldInfoPtr_go), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700208A RID: 8330
			// (get) Token: 0x06005902 RID: 22786 RVA: 0x001428F4 File Offset: 0x00140AF4
			// (set) Token: 0x06005903 RID: 22787 RVA: 0x00032F9B File Offset: 0x0003119B
			public unsafe int touchId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.Touch.NativeFieldInfoPtr_touchId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.Touch.NativeFieldInfoPtr_touchId)) = value;
				}
			}

			// Token: 0x04003B29 RID: 15145
			private static readonly IntPtr NativeFieldInfoPtr_go;

			// Token: 0x04003B2A RID: 15146
			private static readonly IntPtr NativeFieldInfoPtr_touchId;

			// Token: 0x04003B2B RID: 15147
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003A9 RID: 937
		[ObfuscatedName("Rewired.Demos.DualShock4SpecialFeaturesExample+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06005904 RID: 22788 RVA: 0x0014291C File Offset: 0x00140B1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.__c__DisplayClass20_0>.NativeClassPtr);
				DualShock4SpecialFeaturesExample.__c__DisplayClass20_0.NativeFieldInfoPtr_touchId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.__c__DisplayClass20_0>.NativeClassPtr, "touchId");
				DualShock4SpecialFeaturesExample.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.__c__DisplayClass20_0>.NativeClassPtr, 100669598);
				DualShock4SpecialFeaturesExample.__c__DisplayClass20_0.NativeMethodInfoPtr__HandleTouchpad_b__0_Internal_Boolean_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.__c__DisplayClass20_0>.NativeClassPtr, 100669599);
			}

			// Token: 0x06005905 RID: 22789 RVA: 0x00142984 File Offset: 0x00140B84
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005906 RID: 22790 RVA: 0x001429C0 File Offset: 0x00140BC0
			[CallerCount(0)]
			public unsafe bool _HandleTouchpad_b__0(DualShock4SpecialFeaturesExample.Touch x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.__c__DisplayClass20_0.NativeMethodInfoPtr__HandleTouchpad_b__0_Internal_Boolean_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005907 RID: 22791 RVA: 0x00032FB6 File Offset: 0x000311B6
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700208B RID: 8331
			// (get) Token: 0x06005908 RID: 22792 RVA: 0x00142A10 File Offset: 0x00140C10
			// (set) Token: 0x06005909 RID: 22793 RVA: 0x00032FBF File Offset: 0x000311BF
			public unsafe int touchId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.__c__DisplayClass20_0.NativeFieldInfoPtr_touchId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.__c__DisplayClass20_0.NativeFieldInfoPtr_touchId)) = value;
				}
			}

			// Token: 0x04003B2C RID: 15148
			private static readonly IntPtr NativeFieldInfoPtr_touchId;

			// Token: 0x04003B2D RID: 15149
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003B2E RID: 15150
			private static readonly IntPtr NativeMethodInfoPtr__HandleTouchpad_b__0_Internal_Boolean_Touch_0;
		}
	}
}
