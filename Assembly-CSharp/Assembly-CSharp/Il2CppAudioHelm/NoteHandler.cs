using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppAudioHelm
{
	// Token: 0x02000285 RID: 645
	public class NoteHandler : Il2CppObjectBase
	{
		// Token: 0x060047E2 RID: 18402 RVA: 0x0010CE0C File Offset: 0x0010B00C
		// Note: this type is marked as 'beforefieldinit'.
		static NoteHandler()
		{
			Il2CppClassPointerStore<NoteHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AudioHelm", "NoteHandler");
			NoteHandler.NativeMethodInfoPtr_AllNotesOff_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHandler>.NativeClassPtr, 100670711);
			NoteHandler.NativeMethodInfoPtr_NoteOn_Public_Abstract_Virtual_New_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHandler>.NativeClassPtr, 100670712);
			NoteHandler.NativeMethodInfoPtr_NoteOff_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHandler>.NativeClassPtr, 100670713);
		}

		// Token: 0x060047E3 RID: 18403 RVA: 0x0010CE70 File Offset: 0x0010B070
		[CallerCount(0)]
		public unsafe virtual void AllNotesOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHandler.NativeMethodInfoPtr_AllNotesOff_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x0010CEAC File Offset: 0x0010B0AC
		[CallerCount(0)]
		public unsafe virtual void NoteOn(int note, float velocity = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHandler.NativeMethodInfoPtr_NoteOn_Public_Abstract_Virtual_New_Void_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047E5 RID: 18405 RVA: 0x0010CF04 File Offset: 0x0010B104
		[CallerCount(0)]
		public unsafe virtual void NoteOff(int note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHandler.NativeMethodInfoPtr_NoteOff_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047E6 RID: 18406 RVA: 0x0002A458 File Offset: 0x00028658
		public NoteHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E1F RID: 11807
		private static readonly IntPtr NativeMethodInfoPtr_AllNotesOff_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04002E20 RID: 11808
		private static readonly IntPtr NativeMethodInfoPtr_NoteOn_Public_Abstract_Virtual_New_Void_Int32_Single_0;

		// Token: 0x04002E21 RID: 11809
		private static readonly IntPtr NativeMethodInfoPtr_NoteOff_Public_Abstract_Virtual_New_Void_Int32_0;
	}
}
