using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRewired.Demos
{
	// Token: 0x0200020B RID: 523
	public class CustomControllerDemo : MonoBehaviour
	{
		// Token: 0x0600400B RID: 16395 RVA: 0x000EFB74 File Offset: 0x000EDD74
		// Note: this type is marked as 'beforefieldinit'.
		static CustomControllerDemo()
		{
			Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "CustomControllerDemo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr);
			CustomControllerDemo.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, "playerId");
			CustomControllerDemo.NativeFieldInfoPtr_controllerTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, "controllerTag");
			CustomControllerDemo.NativeFieldInfoPtr_useUpdateCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, "useUpdateCallbacks");
			CustomControllerDemo.NativeFieldInfoPtr_buttonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, "buttonCount");
			CustomControllerDemo.NativeFieldInfoPtr_axisCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, "axisCount");
			CustomControllerDemo.NativeFieldInfoPtr_axisValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, "axisValues");
			CustomControllerDemo.NativeFieldInfoPtr_buttonValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, "buttonValues");
			CustomControllerDemo.NativeFieldInfoPtr_joysticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, "joysticks");
			CustomControllerDemo.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, "buttons");
			CustomControllerDemo.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, "controller");
			CustomControllerDemo.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, "initialized");
			CustomControllerDemo.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100669550);
			CustomControllerDemo.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100669551);
			CustomControllerDemo.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100669552);
			CustomControllerDemo.NativeMethodInfoPtr_OnInputSourceUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100669553);
			CustomControllerDemo.NativeMethodInfoPtr_GetSourceAxisValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100669554);
			CustomControllerDemo.NativeMethodInfoPtr_GetSourceButtonValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100669555);
			CustomControllerDemo.NativeMethodInfoPtr_SetControllerAxisValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100669556);
			CustomControllerDemo.NativeMethodInfoPtr_SetControllerButtonValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100669557);
			CustomControllerDemo.NativeMethodInfoPtr_GetAxisValueCallback_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100669558);
			CustomControllerDemo.NativeMethodInfoPtr_GetButtonValueCallback_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100669559);
			CustomControllerDemo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100669560);
		}

		// Token: 0x0600400C RID: 16396 RVA: 0x000EFD5C File Offset: 0x000EDF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103137, XrefRangeEnd = 103147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600400D RID: 16397 RVA: 0x000EFD90 File Offset: 0x000EDF90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 103230, RefRangeEnd = 103232, XrefRangeStart = 103147, XrefRangeEnd = 103230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x000EFDC4 File Offset: 0x000EDFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103232, XrefRangeEnd = 103237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600400F RID: 16399 RVA: 0x000EFDF8 File Offset: 0x000EDFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103237, XrefRangeEnd = 103244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputSourceUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr_OnInputSourceUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004010 RID: 16400 RVA: 0x000EFE2C File Offset: 0x000EE02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103244, XrefRangeEnd = 103246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSourceAxisValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr_GetSourceAxisValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004011 RID: 16401 RVA: 0x000EFE60 File Offset: 0x000EE060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103246, XrefRangeEnd = 103247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSourceButtonValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr_GetSourceButtonValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004012 RID: 16402 RVA: 0x000EFE94 File Offset: 0x000EE094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103247, XrefRangeEnd = 103249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetControllerAxisValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr_SetControllerAxisValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x000EFEC8 File Offset: 0x000EE0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103249, XrefRangeEnd = 103251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetControllerButtonValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr_SetControllerButtonValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x000EFEFC File Offset: 0x000EE0FC
		[CallerCount(0)]
		public unsafe float GetAxisValueCallback(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr_GetAxisValueCallback_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004015 RID: 16405 RVA: 0x000EFF48 File Offset: 0x000EE148
		[CallerCount(0)]
		public unsafe bool GetButtonValueCallback(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr_GetButtonValueCallback_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004016 RID: 16406 RVA: 0x000EFF94 File Offset: 0x000EE194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomControllerDemo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004017 RID: 16407 RVA: 0x00027343 File Offset: 0x00025543
		public CustomControllerDemo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x06004018 RID: 16408 RVA: 0x000EFFD0 File Offset: 0x000EE1D0
		// (set) Token: 0x06004019 RID: 16409 RVA: 0x0002734C File Offset: 0x0002554C
		public unsafe int playerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_playerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_playerId)) = value;
			}
		}

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x0600401A RID: 16410 RVA: 0x000EFFF8 File Offset: 0x000EE1F8
		// (set) Token: 0x0600401B RID: 16411 RVA: 0x00027367 File Offset: 0x00025567
		public unsafe string controllerTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_controllerTag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_controllerTag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x0600401C RID: 16412 RVA: 0x000F0020 File Offset: 0x000EE220
		// (set) Token: 0x0600401D RID: 16413 RVA: 0x00027386 File Offset: 0x00025586
		public unsafe bool useUpdateCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_useUpdateCallbacks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_useUpdateCallbacks)) = value;
			}
		}

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x0600401E RID: 16414 RVA: 0x000F0048 File Offset: 0x000EE248
		// (set) Token: 0x0600401F RID: 16415 RVA: 0x000273A1 File Offset: 0x000255A1
		public unsafe int buttonCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_buttonCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_buttonCount)) = value;
			}
		}

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x06004020 RID: 16416 RVA: 0x000F0070 File Offset: 0x000EE270
		// (set) Token: 0x06004021 RID: 16417 RVA: 0x000273BC File Offset: 0x000255BC
		public unsafe int axisCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_axisCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_axisCount)) = value;
			}
		}

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x06004022 RID: 16418 RVA: 0x000F0098 File Offset: 0x000EE298
		// (set) Token: 0x06004023 RID: 16419 RVA: 0x000273D7 File Offset: 0x000255D7
		public unsafe Il2CppStructArray<float> axisValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_axisValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_axisValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x06004024 RID: 16420 RVA: 0x000F00C8 File Offset: 0x000EE2C8
		// (set) Token: 0x06004025 RID: 16421 RVA: 0x000273F6 File Offset: 0x000255F6
		public unsafe Il2CppStructArray<bool> buttonValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_buttonValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_buttonValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x06004026 RID: 16422 RVA: 0x000F00F8 File Offset: 0x000EE2F8
		// (set) Token: 0x06004027 RID: 16423 RVA: 0x00027415 File Offset: 0x00025615
		public unsafe Il2CppReferenceArray<TouchJoystickExample> joysticks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_joysticks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TouchJoystickExample>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_joysticks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x06004028 RID: 16424 RVA: 0x000F0128 File Offset: 0x000EE328
		// (set) Token: 0x06004029 RID: 16425 RVA: 0x00027434 File Offset: 0x00025634
		public unsafe Il2CppReferenceArray<TouchButtonExample> buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TouchButtonExample>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x0600402A RID: 16426 RVA: 0x000F0158 File Offset: 0x000EE358
		// (set) Token: 0x0600402B RID: 16427 RVA: 0x00027453 File Offset: 0x00025653
		public unsafe CustomController controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x0600402C RID: 16428 RVA: 0x000F0188 File Offset: 0x000EE388
		// (set) Token: 0x0600402D RID: 16429 RVA: 0x00027472 File Offset: 0x00025672
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x04002753 RID: 10067
		private static readonly IntPtr NativeFieldInfoPtr_playerId;

		// Token: 0x04002754 RID: 10068
		private static readonly IntPtr NativeFieldInfoPtr_controllerTag;

		// Token: 0x04002755 RID: 10069
		private static readonly IntPtr NativeFieldInfoPtr_useUpdateCallbacks;

		// Token: 0x04002756 RID: 10070
		private static readonly IntPtr NativeFieldInfoPtr_buttonCount;

		// Token: 0x04002757 RID: 10071
		private static readonly IntPtr NativeFieldInfoPtr_axisCount;

		// Token: 0x04002758 RID: 10072
		private static readonly IntPtr NativeFieldInfoPtr_axisValues;

		// Token: 0x04002759 RID: 10073
		private static readonly IntPtr NativeFieldInfoPtr_buttonValues;

		// Token: 0x0400275A RID: 10074
		private static readonly IntPtr NativeFieldInfoPtr_joysticks;

		// Token: 0x0400275B RID: 10075
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x0400275C RID: 10076
		private static readonly IntPtr NativeFieldInfoPtr_controller;

		// Token: 0x0400275D RID: 10077
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x0400275E RID: 10078
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400275F RID: 10079
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

		// Token: 0x04002760 RID: 10080
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002761 RID: 10081
		private static readonly IntPtr NativeMethodInfoPtr_OnInputSourceUpdate_Private_Void_0;

		// Token: 0x04002762 RID: 10082
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceAxisValues_Private_Void_0;

		// Token: 0x04002763 RID: 10083
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceButtonValues_Private_Void_0;

		// Token: 0x04002764 RID: 10084
		private static readonly IntPtr NativeMethodInfoPtr_SetControllerAxisValues_Private_Void_0;

		// Token: 0x04002765 RID: 10085
		private static readonly IntPtr NativeMethodInfoPtr_SetControllerButtonValues_Private_Void_0;

		// Token: 0x04002766 RID: 10086
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisValueCallback_Private_Single_Int32_0;

		// Token: 0x04002767 RID: 10087
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonValueCallback_Private_Boolean_Int32_0;

		// Token: 0x04002768 RID: 10088
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
