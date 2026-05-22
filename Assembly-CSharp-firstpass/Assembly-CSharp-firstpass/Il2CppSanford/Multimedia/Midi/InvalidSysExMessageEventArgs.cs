using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001A7 RID: 423
	public class InvalidSysExMessageEventArgs : EventArgs
	{
		// Token: 0x06001433 RID: 5171 RVA: 0x0005DA68 File Offset: 0x0005BC68
		// Note: this type is marked as 'beforefieldinit'.
		static InvalidSysExMessageEventArgs()
		{
			Il2CppClassPointerStore<InvalidSysExMessageEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "InvalidSysExMessageEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvalidSysExMessageEventArgs>.NativeClassPtr);
			InvalidSysExMessageEventArgs.NativeFieldInfoPtr_messageData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidSysExMessageEventArgs>.NativeClassPtr, "messageData");
			InvalidSysExMessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidSysExMessageEventArgs>.NativeClassPtr, 100666174);
			InvalidSysExMessageEventArgs.NativeMethodInfoPtr_get_MessageData_Public_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidSysExMessageEventArgs>.NativeClassPtr, 100666175);
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0005DAD4 File Offset: 0x0005BCD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16158, XrefRangeEnd = 16161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidSysExMessageEventArgs(Il2CppStructArray<byte> messageData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidSysExMessageEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(messageData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidSysExMessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x0005DB20 File Offset: 0x0005BD20
		public unsafe ICollection MessageData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidSysExMessageEventArgs.NativeMethodInfoPtr_get_MessageData_Public_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00008459 File Offset: 0x00006659
		public InvalidSysExMessageEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x0005DB60 File Offset: 0x0005BD60
		// (set) Token: 0x06001438 RID: 5176 RVA: 0x00008462 File Offset: 0x00006662
		public unsafe Il2CppStructArray<byte> messageData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidSysExMessageEventArgs.NativeFieldInfoPtr_messageData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidSysExMessageEventArgs.NativeFieldInfoPtr_messageData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400165E RID: 5726
		private static readonly IntPtr NativeFieldInfoPtr_messageData;

		// Token: 0x0400165F RID: 5727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001660 RID: 5728
		private static readonly IntPtr NativeMethodInfoPtr_get_MessageData_Public_get_ICollection_0;
	}
}
