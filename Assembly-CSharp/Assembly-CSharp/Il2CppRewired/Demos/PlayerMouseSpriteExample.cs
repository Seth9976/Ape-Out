using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRewired.Demos
{
	// Token: 0x02000212 RID: 530
	public class PlayerMouseSpriteExample : MonoBehaviour
	{
		// Token: 0x060040C1 RID: 16577 RVA: 0x000F1C7C File Offset: 0x000EFE7C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerMouseSpriteExample()
		{
			Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "PlayerMouseSpriteExample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr);
			PlayerMouseSpriteExample.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, "playerId");
			PlayerMouseSpriteExample.NativeFieldInfoPtr_horizontalAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, "horizontalAction");
			PlayerMouseSpriteExample.NativeFieldInfoPtr_verticalAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, "verticalAction");
			PlayerMouseSpriteExample.NativeFieldInfoPtr_wheelAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, "wheelAction");
			PlayerMouseSpriteExample.NativeFieldInfoPtr_leftButtonAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, "leftButtonAction");
			PlayerMouseSpriteExample.NativeFieldInfoPtr_rightButtonAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, "rightButtonAction");
			PlayerMouseSpriteExample.NativeFieldInfoPtr_middleButtonAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, "middleButtonAction");
			PlayerMouseSpriteExample.NativeFieldInfoPtr_distanceFromCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, "distanceFromCamera");
			PlayerMouseSpriteExample.NativeFieldInfoPtr_spriteScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, "spriteScale");
			PlayerMouseSpriteExample.NativeFieldInfoPtr_pointerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, "pointerPrefab");
			PlayerMouseSpriteExample.NativeFieldInfoPtr_clickEffectPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, "clickEffectPrefab");
			PlayerMouseSpriteExample.NativeFieldInfoPtr_hideHardwarePointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, "hideHardwarePointer");
			PlayerMouseSpriteExample.NativeFieldInfoPtr_pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, "pointer");
			PlayerMouseSpriteExample.NativeFieldInfoPtr_mouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, "mouse");
			PlayerMouseSpriteExample.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, 100669615);
			PlayerMouseSpriteExample.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, 100669616);
			PlayerMouseSpriteExample.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, 100669617);
			PlayerMouseSpriteExample.NativeMethodInfoPtr_CreateClickEffect_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, 100669618);
			PlayerMouseSpriteExample.NativeMethodInfoPtr_OnScreenPositionChanged_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, 100669619);
			PlayerMouseSpriteExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, 100669620);
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x000F1E3C File Offset: 0x000F003C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103950, XrefRangeEnd = 104005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouseSpriteExample.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x000F1E70 File Offset: 0x000F0070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104005, XrefRangeEnd = 104033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouseSpriteExample.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x000F1EA4 File Offset: 0x000F00A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104033, XrefRangeEnd = 104044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouseSpriteExample.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040C5 RID: 16581 RVA: 0x000F1ED8 File Offset: 0x000F00D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 104087, RefRangeEnd = 104090, XrefRangeStart = 104044, XrefRangeEnd = 104087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateClickEffect(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouseSpriteExample.NativeMethodInfoPtr_CreateClickEffect_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040C6 RID: 16582 RVA: 0x000F1F18 File Offset: 0x000F0118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104090, XrefRangeEnd = 104098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnScreenPositionChanged(Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouseSpriteExample.NativeMethodInfoPtr_OnScreenPositionChanged_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040C7 RID: 16583 RVA: 0x000F1F58 File Offset: 0x000F0158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104098, XrefRangeEnd = 104113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerMouseSpriteExample()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouseSpriteExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x00027935 File Offset: 0x00025B35
		public PlayerMouseSpriteExample(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x060040C9 RID: 16585 RVA: 0x000F1F94 File Offset: 0x000F0194
		// (set) Token: 0x060040CA RID: 16586 RVA: 0x0002793E File Offset: 0x00025B3E
		public unsafe int playerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_playerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_playerId)) = value;
			}
		}

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x060040CB RID: 16587 RVA: 0x000F1FBC File Offset: 0x000F01BC
		// (set) Token: 0x060040CC RID: 16588 RVA: 0x00027959 File Offset: 0x00025B59
		public unsafe string horizontalAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_horizontalAction);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_horizontalAction), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x060040CD RID: 16589 RVA: 0x000F1FE4 File Offset: 0x000F01E4
		// (set) Token: 0x060040CE RID: 16590 RVA: 0x00027978 File Offset: 0x00025B78
		public unsafe string verticalAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_verticalAction);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_verticalAction), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x060040CF RID: 16591 RVA: 0x000F200C File Offset: 0x000F020C
		// (set) Token: 0x060040D0 RID: 16592 RVA: 0x00027997 File Offset: 0x00025B97
		public unsafe string wheelAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_wheelAction);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_wheelAction), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x060040D1 RID: 16593 RVA: 0x000F2034 File Offset: 0x000F0234
		// (set) Token: 0x060040D2 RID: 16594 RVA: 0x000279B6 File Offset: 0x00025BB6
		public unsafe string leftButtonAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_leftButtonAction);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_leftButtonAction), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x060040D3 RID: 16595 RVA: 0x000F205C File Offset: 0x000F025C
		// (set) Token: 0x060040D4 RID: 16596 RVA: 0x000279D5 File Offset: 0x00025BD5
		public unsafe string rightButtonAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_rightButtonAction);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_rightButtonAction), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x060040D5 RID: 16597 RVA: 0x000F2084 File Offset: 0x000F0284
		// (set) Token: 0x060040D6 RID: 16598 RVA: 0x000279F4 File Offset: 0x00025BF4
		public unsafe string middleButtonAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_middleButtonAction);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_middleButtonAction), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x060040D7 RID: 16599 RVA: 0x000F20AC File Offset: 0x000F02AC
		// (set) Token: 0x060040D8 RID: 16600 RVA: 0x00027A13 File Offset: 0x00025C13
		public unsafe float distanceFromCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_distanceFromCamera);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_distanceFromCamera)) = value;
			}
		}

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x060040D9 RID: 16601 RVA: 0x000F20D4 File Offset: 0x000F02D4
		// (set) Token: 0x060040DA RID: 16602 RVA: 0x00027A2E File Offset: 0x00025C2E
		public unsafe float spriteScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_spriteScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_spriteScale)) = value;
			}
		}

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x060040DB RID: 16603 RVA: 0x000F20FC File Offset: 0x000F02FC
		// (set) Token: 0x060040DC RID: 16604 RVA: 0x00027A49 File Offset: 0x00025C49
		public unsafe GameObject pointerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_pointerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_pointerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x060040DD RID: 16605 RVA: 0x000F212C File Offset: 0x000F032C
		// (set) Token: 0x060040DE RID: 16606 RVA: 0x00027A68 File Offset: 0x00025C68
		public unsafe GameObject clickEffectPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_clickEffectPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_clickEffectPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x060040DF RID: 16607 RVA: 0x000F215C File Offset: 0x000F035C
		// (set) Token: 0x060040E0 RID: 16608 RVA: 0x00027A87 File Offset: 0x00025C87
		public unsafe bool hideHardwarePointer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_hideHardwarePointer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_hideHardwarePointer)) = value;
			}
		}

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x060040E1 RID: 16609 RVA: 0x000F2184 File Offset: 0x000F0384
		// (set) Token: 0x060040E2 RID: 16610 RVA: 0x00027AA2 File Offset: 0x00025CA2
		public unsafe GameObject pointer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_pointer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_pointer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x060040E3 RID: 16611 RVA: 0x000F21B4 File Offset: 0x000F03B4
		// (set) Token: 0x060040E4 RID: 16612 RVA: 0x00027AC1 File Offset: 0x00025CC1
		public unsafe PlayerMouse mouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_mouse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerMouse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_mouse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027C6 RID: 10182
		private static readonly IntPtr NativeFieldInfoPtr_playerId;

		// Token: 0x040027C7 RID: 10183
		private static readonly IntPtr NativeFieldInfoPtr_horizontalAction;

		// Token: 0x040027C8 RID: 10184
		private static readonly IntPtr NativeFieldInfoPtr_verticalAction;

		// Token: 0x040027C9 RID: 10185
		private static readonly IntPtr NativeFieldInfoPtr_wheelAction;

		// Token: 0x040027CA RID: 10186
		private static readonly IntPtr NativeFieldInfoPtr_leftButtonAction;

		// Token: 0x040027CB RID: 10187
		private static readonly IntPtr NativeFieldInfoPtr_rightButtonAction;

		// Token: 0x040027CC RID: 10188
		private static readonly IntPtr NativeFieldInfoPtr_middleButtonAction;

		// Token: 0x040027CD RID: 10189
		private static readonly IntPtr NativeFieldInfoPtr_distanceFromCamera;

		// Token: 0x040027CE RID: 10190
		private static readonly IntPtr NativeFieldInfoPtr_spriteScale;

		// Token: 0x040027CF RID: 10191
		private static readonly IntPtr NativeFieldInfoPtr_pointerPrefab;

		// Token: 0x040027D0 RID: 10192
		private static readonly IntPtr NativeFieldInfoPtr_clickEffectPrefab;

		// Token: 0x040027D1 RID: 10193
		private static readonly IntPtr NativeFieldInfoPtr_hideHardwarePointer;

		// Token: 0x040027D2 RID: 10194
		private static readonly IntPtr NativeFieldInfoPtr_pointer;

		// Token: 0x040027D3 RID: 10195
		private static readonly IntPtr NativeFieldInfoPtr_mouse;

		// Token: 0x040027D4 RID: 10196
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040027D5 RID: 10197
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040027D6 RID: 10198
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040027D7 RID: 10199
		private static readonly IntPtr NativeMethodInfoPtr_CreateClickEffect_Private_Void_Color_0;

		// Token: 0x040027D8 RID: 10200
		private static readonly IntPtr NativeMethodInfoPtr_OnScreenPositionChanged_Private_Void_Vector2_0;

		// Token: 0x040027D9 RID: 10201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
