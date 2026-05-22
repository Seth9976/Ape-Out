using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x0200019E RID: 414
	public class OutputDeviceException : MidiDeviceException
	{
		// Token: 0x06001395 RID: 5013 RVA: 0x0005B63C File Offset: 0x0005983C
		// Note: this type is marked as 'beforefieldinit'.
		static OutputDeviceException()
		{
			Il2CppClassPointerStore<OutputDeviceException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "OutputDeviceException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutputDeviceException>.NativeClassPtr);
			OutputDeviceException.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputDeviceException>.NativeClassPtr, "message");
			OutputDeviceException.NativeMethodInfoPtr_midiOutGetErrorText_Private_Static_Int32_Int32_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceException>.NativeClassPtr, 100666088);
			OutputDeviceException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceException>.NativeClassPtr, 100666089);
			OutputDeviceException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceException>.NativeClassPtr, 100666090);
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x0005B6BC File Offset: 0x000598BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15631, XrefRangeEnd = 15634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiOutGetErrorText(int errCode, StringBuilder message, int sizeOfMessage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeOfMessage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceException.NativeMethodInfoPtr_midiOutGetErrorText_Private_Static_Int32_Int32_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x0005B71C File Offset: 0x0005991C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 15645, RefRangeEnd = 15648, XrefRangeStart = 15634, XrefRangeEnd = 15645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutputDeviceException(int errCode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutputDeviceException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x0005B764 File Offset: 0x00059964
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OutputDeviceException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x0000815B File Offset: 0x0000635B
		public OutputDeviceException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x0005B7A8 File Offset: 0x000599A8
		// (set) Token: 0x0600139B RID: 5019 RVA: 0x00008164 File Offset: 0x00006364
		public unsafe StringBuilder message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDeviceException.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDeviceException.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001522 RID: 5410
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04001523 RID: 5411
		private static readonly IntPtr NativeMethodInfoPtr_midiOutGetErrorText_Private_Static_Int32_Int32_StringBuilder_Int32_0;

		// Token: 0x04001524 RID: 5412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001525 RID: 5413
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;
	}
}
