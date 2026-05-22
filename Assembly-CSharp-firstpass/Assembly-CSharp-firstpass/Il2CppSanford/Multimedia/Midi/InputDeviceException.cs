using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x02000195 RID: 405
	public class InputDeviceException : MidiDeviceException
	{
		// Token: 0x0600130D RID: 4877 RVA: 0x0005A058 File Offset: 0x00058258
		// Note: this type is marked as 'beforefieldinit'.
		static InputDeviceException()
		{
			Il2CppClassPointerStore<InputDeviceException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "InputDeviceException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDeviceException>.NativeClassPtr);
			InputDeviceException.NativeFieldInfoPtr_errMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceException>.NativeClassPtr, "errMsg");
			InputDeviceException.NativeMethodInfoPtr_midiInGetErrorText_Private_Static_Int32_Int32_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceException>.NativeClassPtr, 100666056);
			InputDeviceException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceException>.NativeClassPtr, 100666057);
			InputDeviceException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceException>.NativeClassPtr, 100666058);
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x0005A0D8 File Offset: 0x000582D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15433, XrefRangeEnd = 15436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiInGetErrorText(int errCode, StringBuilder errMsg, int sizeOfErrMsg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(errMsg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeOfErrMsg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceException.NativeMethodInfoPtr_midiInGetErrorText_Private_Static_Int32_Int32_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x0005A138 File Offset: 0x00058338
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 15447, RefRangeEnd = 15451, XrefRangeStart = 15436, XrefRangeEnd = 15447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputDeviceException(int errCode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDeviceException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x0005A180 File Offset: 0x00058380
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15451, XrefRangeEnd = 15452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDeviceException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00007CD0 File Offset: 0x00005ED0
		public InputDeviceException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x0005A1C4 File Offset: 0x000583C4
		// (set) Token: 0x06001313 RID: 4883 RVA: 0x00007CD9 File Offset: 0x00005ED9
		public unsafe StringBuilder errMsg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceException.NativeFieldInfoPtr_errMsg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceException.NativeFieldInfoPtr_errMsg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014D9 RID: 5337
		private static readonly IntPtr NativeFieldInfoPtr_errMsg;

		// Token: 0x040014DA RID: 5338
		private static readonly IntPtr NativeMethodInfoPtr_midiInGetErrorText_Private_Static_Int32_Int32_StringBuilder_Int32_0;

		// Token: 0x040014DB RID: 5339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040014DC RID: 5340
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;
	}
}
