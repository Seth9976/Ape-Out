using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x0200013B RID: 315
	public class MySaveFilePC : Object
	{
		// Token: 0x06002693 RID: 9875 RVA: 0x0009F7AC File Offset: 0x0009D9AC
		// Note: this type is marked as 'beforefieldinit'.
		static MySaveFilePC()
		{
			Il2CppClassPointerStore<MySaveFilePC>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MySaveFilePC");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MySaveFilePC>.NativeClassPtr);
			MySaveFilePC.NativeMethodInfoPtr_get_SaveDataPath1_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySaveFilePC>.NativeClassPtr, 100666382);
			MySaveFilePC.NativeMethodInfoPtr_Exists_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySaveFilePC>.NativeClassPtr, 100666383);
			MySaveFilePC.NativeMethodInfoPtr_ReadAllText_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySaveFilePC>.NativeClassPtr, 100666384);
			MySaveFilePC.NativeMethodInfoPtr_WriteAllText_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySaveFilePC>.NativeClassPtr, 100666385);
			MySaveFilePC.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySaveFilePC>.NativeClassPtr, 100666386);
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06002694 RID: 9876 RVA: 0x0009F840 File Offset: 0x0009DA40
		public unsafe static string SaveDataPath1
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 74820, RefRangeEnd = 74823, XrefRangeStart = 74813, XrefRangeEnd = 74820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySaveFilePC.NativeMethodInfoPtr_get_SaveDataPath1_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x0009F86C File Offset: 0x0009DA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74823, XrefRangeEnd = 74826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Exists(string filename)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySaveFilePC.NativeMethodInfoPtr_Exists_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x0009F8BC File Offset: 0x0009DABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74826, XrefRangeEnd = 74829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ReadAllText(string filename)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySaveFilePC.NativeMethodInfoPtr_ReadAllText_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x0009F904 File Offset: 0x0009DB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74829, XrefRangeEnd = 74832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySaveFilePC.NativeMethodInfoPtr_WriteAllText_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x0009F958 File Offset: 0x0009DB58
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MySaveFilePC()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MySaveFilePC>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySaveFilePC.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x0001AE1F File Offset: 0x0001901F
		public MySaveFilePC(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016C6 RID: 5830
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveDataPath1_Public_Static_get_String_0;

		// Token: 0x040016C7 RID: 5831
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Virtual_Final_New_Boolean_String_0;

		// Token: 0x040016C8 RID: 5832
		private static readonly IntPtr NativeMethodInfoPtr_ReadAllText_Public_Virtual_Final_New_String_String_0;

		// Token: 0x040016C9 RID: 5833
		private static readonly IntPtr NativeMethodInfoPtr_WriteAllText_Public_Virtual_Final_New_Void_String_String_0;

		// Token: 0x040016CA RID: 5834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
