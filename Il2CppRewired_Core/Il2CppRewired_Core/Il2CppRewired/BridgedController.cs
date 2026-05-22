using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Interfaces;
using Il2CppRewired.Platforms.Custom;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x02000109 RID: 265
	public class BridgedController : BridgedControllerHWInfo
	{
		// Token: 0x060019D2 RID: 6610 RVA: 0x000921AC File Offset: 0x000903AC
		// Note: this type is marked as 'beforefieldinit'.
		static BridgedController()
		{
			Il2CppClassPointerStore<BridgedController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "BridgedController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BridgedController>.NativeClassPtr);
			BridgedController.NativeFieldInfoPtr_sourceJoystick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedController>.NativeClassPtr, "sourceJoystick");
			BridgedController.NativeFieldInfoPtr_gameHardwareMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedController>.NativeClassPtr, "gameHardwareMap");
			BridgedController.NativeFieldInfoPtr_controllerTypeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedController>.NativeClassPtr, "controllerTypeGuid");
			BridgedController.NativeFieldInfoPtr_controllerExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedController>.NativeClassPtr, "controllerExtension");
			BridgedController.NativeFieldInfoPtr_instanceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedController>.NativeClassPtr, "instanceName");
			BridgedController.NativeFieldInfoPtr_productName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedController>.NativeClassPtr, "productName");
			BridgedController.NativeFieldInfoPtr_isXInputDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedController>.NativeClassPtr, "isXInputDevice");
			BridgedController.NativeFieldInfoPtr_axisCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedController>.NativeClassPtr, "axisCount");
			BridgedController.NativeFieldInfoPtr_buttonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedController>.NativeClassPtr, "buttonCount");
			BridgedController.NativeFieldInfoPtr_isButtonPressureSensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedController>.NativeClassPtr, "isButtonPressureSensitive");
			BridgedController.NativeFieldInfoPtr_unknownControllerHats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedController>.NativeClassPtr, "unknownControllerHats");
			BridgedController.NativeFieldInfoPtr_customInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedController>.NativeClassPtr, "customInputSource");
			BridgedController.NativeMethodInfoPtr_get_isUnknownController_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BridgedController>.NativeClassPtr, 100669477);
			BridgedController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BridgedController>.NativeClassPtr, 100669478);
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x060019D3 RID: 6611 RVA: 0x000922F4 File Offset: 0x000904F4
		public unsafe bool isUnknownController
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279009, XrefRangeEnd = 279014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BridgedController.NativeMethodInfoPtr_get_isUnknownController_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x00092330 File Offset: 0x00090530
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BridgedController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BridgedController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BridgedController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x0000A715 File Offset: 0x00008915
		public BridgedController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x0009236C File Offset: 0x0009056C
		// (set) Token: 0x060019D7 RID: 6615 RVA: 0x0000A71E File Offset: 0x0000891E
		public unsafe IInputManagerJoystickPublic sourceJoystick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_sourceJoystick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IInputManagerJoystickPublic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_sourceJoystick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x0009239C File Offset: 0x0009059C
		// (set) Token: 0x060019D9 RID: 6617 RVA: 0x0000A73D File Offset: 0x0000893D
		public unsafe HardwareControllerMap_Game gameHardwareMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_gameHardwareMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HardwareControllerMap_Game>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_gameHardwareMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x000923CC File Offset: 0x000905CC
		// (set) Token: 0x060019DB RID: 6619 RVA: 0x0000A75C File Offset: 0x0000895C
		public unsafe Guid controllerTypeGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_controllerTypeGuid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_controllerTypeGuid)) = value;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x060019DC RID: 6620 RVA: 0x000923F4 File Offset: 0x000905F4
		// (set) Token: 0x060019DD RID: 6621 RVA: 0x0000A777 File Offset: 0x00008977
		public unsafe Controller.Extension controllerExtension
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_controllerExtension);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_controllerExtension), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x00092424 File Offset: 0x00090624
		// (set) Token: 0x060019DF RID: 6623 RVA: 0x0000A796 File Offset: 0x00008996
		public unsafe string instanceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_instanceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_instanceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x0009244C File Offset: 0x0009064C
		// (set) Token: 0x060019E1 RID: 6625 RVA: 0x0000A7B5 File Offset: 0x000089B5
		public unsafe string productName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_productName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_productName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x00092474 File Offset: 0x00090674
		// (set) Token: 0x060019E3 RID: 6627 RVA: 0x0000A7D4 File Offset: 0x000089D4
		public unsafe bool isXInputDevice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_isXInputDevice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_isXInputDevice)) = value;
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x0009249C File Offset: 0x0009069C
		// (set) Token: 0x060019E5 RID: 6629 RVA: 0x0000A7EF File Offset: 0x000089EF
		public unsafe int axisCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_axisCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_axisCount)) = value;
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x000924C4 File Offset: 0x000906C4
		// (set) Token: 0x060019E7 RID: 6631 RVA: 0x0000A80A File Offset: 0x00008A0A
		public unsafe int buttonCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_buttonCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_buttonCount)) = value;
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x000924EC File Offset: 0x000906EC
		// (set) Token: 0x060019E9 RID: 6633 RVA: 0x0000A825 File Offset: 0x00008A25
		public unsafe Il2CppStructArray<bool> isButtonPressureSensitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_isButtonPressureSensitive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_isButtonPressureSensitive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x0009251C File Offset: 0x0009071C
		// (set) Token: 0x060019EB RID: 6635 RVA: 0x0000A844 File Offset: 0x00008A44
		public unsafe Il2CppReferenceArray<UnknownControllerHat> unknownControllerHats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_unknownControllerHats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnknownControllerHat>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_unknownControllerHats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x0009254C File Offset: 0x0009074C
		// (set) Token: 0x060019ED RID: 6637 RVA: 0x0000A863 File Offset: 0x00008A63
		public unsafe CustomInputSource customInputSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_customInputSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomInputSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedController.NativeFieldInfoPtr_customInputSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001659 RID: 5721
		private static readonly IntPtr NativeFieldInfoPtr_sourceJoystick;

		// Token: 0x0400165A RID: 5722
		private static readonly IntPtr NativeFieldInfoPtr_gameHardwareMap;

		// Token: 0x0400165B RID: 5723
		private static readonly IntPtr NativeFieldInfoPtr_controllerTypeGuid;

		// Token: 0x0400165C RID: 5724
		private static readonly IntPtr NativeFieldInfoPtr_controllerExtension;

		// Token: 0x0400165D RID: 5725
		private static readonly IntPtr NativeFieldInfoPtr_instanceName;

		// Token: 0x0400165E RID: 5726
		private static readonly IntPtr NativeFieldInfoPtr_productName;

		// Token: 0x0400165F RID: 5727
		private static readonly IntPtr NativeFieldInfoPtr_isXInputDevice;

		// Token: 0x04001660 RID: 5728
		private static readonly IntPtr NativeFieldInfoPtr_axisCount;

		// Token: 0x04001661 RID: 5729
		private static readonly IntPtr NativeFieldInfoPtr_buttonCount;

		// Token: 0x04001662 RID: 5730
		private static readonly IntPtr NativeFieldInfoPtr_isButtonPressureSensitive;

		// Token: 0x04001663 RID: 5731
		private static readonly IntPtr NativeFieldInfoPtr_unknownControllerHats;

		// Token: 0x04001664 RID: 5732
		private static readonly IntPtr NativeFieldInfoPtr_customInputSource;

		// Token: 0x04001665 RID: 5733
		private static readonly IntPtr NativeMethodInfoPtr_get_isUnknownController_Public_get_Boolean_0;

		// Token: 0x04001666 RID: 5734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
