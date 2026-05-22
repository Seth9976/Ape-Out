using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2Cpp
{
	// Token: 0x0200013A RID: 314
	public class MySaveFileInterface : Il2CppObjectBase
	{
		// Token: 0x0600268E RID: 9870 RVA: 0x0009F63C File Offset: 0x0009D83C
		// Note: this type is marked as 'beforefieldinit'.
		static MySaveFileInterface()
		{
			Il2CppClassPointerStore<MySaveFileInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MySaveFileInterface");
			MySaveFileInterface.NativeMethodInfoPtr_Exists_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySaveFileInterface>.NativeClassPtr, 100666379);
			MySaveFileInterface.NativeMethodInfoPtr_ReadAllText_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySaveFileInterface>.NativeClassPtr, 100666380);
			MySaveFileInterface.NativeMethodInfoPtr_WriteAllText_Public_Abstract_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySaveFileInterface>.NativeClassPtr, 100666381);
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x0009F6A0 File Offset: 0x0009D8A0
		[CallerCount(0)]
		public unsafe virtual bool Exists(string filename)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MySaveFileInterface.NativeMethodInfoPtr_Exists_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x0009F6F8 File Offset: 0x0009D8F8
		[CallerCount(0)]
		public unsafe virtual string ReadAllText(string filename)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MySaveFileInterface.NativeMethodInfoPtr_ReadAllText_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x0009F74C File Offset: 0x0009D94C
		[CallerCount(0)]
		public unsafe virtual void WriteAllText(string filename, string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MySaveFileInterface.NativeMethodInfoPtr_WriteAllText_Public_Abstract_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x0001AE16 File Offset: 0x00019016
		public MySaveFileInterface(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016C3 RID: 5827
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Abstract_Virtual_New_Boolean_String_0;

		// Token: 0x040016C4 RID: 5828
		private static readonly IntPtr NativeMethodInfoPtr_ReadAllText_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x040016C5 RID: 5829
		private static readonly IntPtr NativeMethodInfoPtr_WriteAllText_Public_Abstract_Virtual_New_Void_String_String_0;
	}
}
