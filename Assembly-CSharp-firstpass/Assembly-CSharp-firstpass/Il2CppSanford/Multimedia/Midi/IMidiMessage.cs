using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001AE RID: 430
	public class IMidiMessage : Il2CppObjectBase
	{
		// Token: 0x0600146A RID: 5226 RVA: 0x0005E4E8 File Offset: 0x0005C6E8
		// Note: this type is marked as 'beforefieldinit'.
		static IMidiMessage()
		{
			Il2CppClassPointerStore<IMidiMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "IMidiMessage");
			IMidiMessage.NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMidiMessage>.NativeClassPtr, 100666192);
			IMidiMessage.NativeMethodInfoPtr_get_Status_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMidiMessage>.NativeClassPtr, 100666193);
			IMidiMessage.NativeMethodInfoPtr_get_MessageType_Public_Abstract_Virtual_New_get_MessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMidiMessage>.NativeClassPtr, 100666194);
			IMidiMessage.NativeMethodInfoPtr_get_DeltaFrames_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMidiMessage>.NativeClassPtr, 100666195);
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x0005E560 File Offset: 0x0005C760
		[CallerCount(0)]
		public unsafe virtual Il2CppStructArray<byte> GetBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMidiMessage.NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x0005E5AC File Offset: 0x0005C7AC
		public unsafe virtual int Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMidiMessage.NativeMethodInfoPtr_get_Status_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x0005E5F4 File Offset: 0x0005C7F4
		public unsafe virtual MessageType MessageType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMidiMessage.NativeMethodInfoPtr_get_MessageType_Public_Abstract_Virtual_New_get_MessageType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x0005E63C File Offset: 0x0005C83C
		public unsafe virtual int DeltaFrames
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMidiMessage.NativeMethodInfoPtr_get_DeltaFrames_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x000085C7 File Offset: 0x000067C7
		public IMidiMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001683 RID: 5763
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001684 RID: 5764
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001685 RID: 5765
		private static readonly IntPtr NativeMethodInfoPtr_get_MessageType_Public_Abstract_Virtual_New_get_MessageType_0;

		// Token: 0x04001686 RID: 5766
		private static readonly IntPtr NativeMethodInfoPtr_get_DeltaFrames_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
