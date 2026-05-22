using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppRewired.Drivers.Interfaces
{
	// Token: 0x02000102 RID: 258
	public class IDriver_RailDriver : Il2CppObjectBase
	{
		// Token: 0x0600197C RID: 6524 RVA: 0x000915A0 File Offset: 0x0008F7A0
		// Note: this type is marked as 'beforefieldinit'.
		static IDriver_RailDriver()
		{
			Il2CppClassPointerStore<IDriver_RailDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Drivers.Interfaces", "IDriver_RailDriver");
			IDriver_RailDriver.NativeMethodInfoPtr_get_SpeakerEnabled_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_RailDriver>.NativeClassPtr, 100669465);
			IDriver_RailDriver.NativeMethodInfoPtr_set_SpeakerEnabled_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_RailDriver>.NativeClassPtr, 100669466);
			IDriver_RailDriver.NativeMethodInfoPtr_SetLEDDisplay_Public_Abstract_Virtual_New_Void_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_RailDriver>.NativeClassPtr, 100669467);
			IDriver_RailDriver.NativeMethodInfoPtr_SetLEDDisplay_Public_Abstract_Virtual_New_Void_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_RailDriver>.NativeClassPtr, 100669468);
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x0600197D RID: 6525 RVA: 0x00091618 File Offset: 0x0008F818
		// (set) Token: 0x0600197E RID: 6526 RVA: 0x00091660 File Offset: 0x0008F860
		public unsafe virtual bool SpeakerEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_RailDriver.NativeMethodInfoPtr_get_SpeakerEnabled_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_RailDriver.NativeMethodInfoPtr_set_SpeakerEnabled_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x000916AC File Offset: 0x0008F8AC
		[CallerCount(0)]
		public unsafe virtual void SetLEDDisplay(int digitIndex, byte digitBitValues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref digitIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitBitValues;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_RailDriver.NativeMethodInfoPtr_SetLEDDisplay_Public_Abstract_Virtual_New_Void_Int32_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00091704 File Offset: 0x0008F904
		[CallerCount(0)]
		public unsafe virtual void SetLEDDisplay(byte digit1BitValues, byte digit2BitValues, byte digit3BitValues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref digit1BitValues;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digit2BitValues;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digit3BitValues;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_RailDriver.NativeMethodInfoPtr_SetLEDDisplay_Public_Abstract_Virtual_New_Void_Byte_Byte_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x0000A308 File Offset: 0x00008508
		public IDriver_RailDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400162F RID: 5679
		private static readonly IntPtr NativeMethodInfoPtr_get_SpeakerEnabled_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001630 RID: 5680
		private static readonly IntPtr NativeMethodInfoPtr_set_SpeakerEnabled_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04001631 RID: 5681
		private static readonly IntPtr NativeMethodInfoPtr_SetLEDDisplay_Public_Abstract_Virtual_New_Void_Int32_Byte_0;

		// Token: 0x04001632 RID: 5682
		private static readonly IntPtr NativeMethodInfoPtr_SetLEDDisplay_Public_Abstract_Virtual_New_Void_Byte_Byte_Byte_0;
	}
}
