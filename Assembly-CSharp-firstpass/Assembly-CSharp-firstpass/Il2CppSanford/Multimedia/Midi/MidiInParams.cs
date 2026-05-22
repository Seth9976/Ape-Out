using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x02000194 RID: 404
	[StructLayout(2)]
	public struct MidiInParams
	{
		// Token: 0x0600130A RID: 4874 RVA: 0x00059FAC File Offset: 0x000581AC
		// Note: this type is marked as 'beforefieldinit'.
		static MidiInParams()
		{
			Il2CppClassPointerStore<MidiInParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "MidiInParams");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MidiInParams>.NativeClassPtr);
			MidiInParams.NativeFieldInfoPtr_Param1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiInParams>.NativeClassPtr, "Param1");
			MidiInParams.NativeFieldInfoPtr_Param2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiInParams>.NativeClassPtr, "Param2");
			MidiInParams.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiInParams>.NativeClassPtr, 100666055);
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x0005A018 File Offset: 0x00058218
		[CallerCount(0)]
		public unsafe MidiInParams(IntPtr param1, IntPtr param2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref param1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref param2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiInParams.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00007CBE File Offset: 0x00005EBE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MidiInParams>.NativeClassPtr, ref this));
		}

		// Token: 0x040014D4 RID: 5332
		private static readonly IntPtr NativeFieldInfoPtr_Param1;

		// Token: 0x040014D5 RID: 5333
		private static readonly IntPtr NativeFieldInfoPtr_Param2;

		// Token: 0x040014D6 RID: 5334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_IntPtr_0;

		// Token: 0x040014D7 RID: 5335
		[FieldOffset(0)]
		public readonly IntPtr Param1;

		// Token: 0x040014D8 RID: 5336
		[FieldOffset(8)]
		public readonly IntPtr Param2;
	}
}
