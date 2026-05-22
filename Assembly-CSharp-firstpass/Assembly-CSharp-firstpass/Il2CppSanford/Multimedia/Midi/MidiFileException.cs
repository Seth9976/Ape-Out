using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001CF RID: 463
	public class MidiFileException : ApplicationException
	{
		// Token: 0x0600166D RID: 5741 RVA: 0x0000901C File Offset: 0x0000721C
		// Note: this type is marked as 'beforefieldinit'.
		static MidiFileException()
		{
			Il2CppClassPointerStore<MidiFileException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "MidiFileException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MidiFileException>.NativeClassPtr);
			MidiFileException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiFileException>.NativeClassPtr, 100666465);
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00065AF4 File Offset: 0x00063CF4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 14773, RefRangeEnd = 14779, XrefRangeStart = 14773, XrefRangeEnd = 14779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MidiFileException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MidiFileException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiFileException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x00009055 File Offset: 0x00007255
		public MidiFileException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001818 RID: 6168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
