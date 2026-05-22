using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000354 RID: 852
	public static class IOUtil : Object
	{
		// Token: 0x06003763 RID: 14179 RVA: 0x0010EC64 File Offset: 0x0010CE64
		// Note: this type is marked as 'beforefieldinit'.
		static IOUtil()
		{
			Il2CppClassPointerStore<IOUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "IOUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOUtil>.NativeClassPtr);
			IOUtil.NativeMethodInfoPtr_FlagTest_Internal_Static_Boolean_MessageEnum_MessageEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOUtil>.NativeClassPtr, 100671873);
			IOUtil.NativeMethodInfoPtr_WriteStringWithCode_Internal_Static_Void_String___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOUtil>.NativeClassPtr, 100671874);
			IOUtil.NativeMethodInfoPtr_WriteWithCode_Internal_Static_Void_Type_Object___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOUtil>.NativeClassPtr, 100671875);
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x0010ECD0 File Offset: 0x0010CED0
		[CallerCount(0)]
		public unsafe static bool FlagTest(MessageEnum flag, MessageEnum target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flag;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOUtil.NativeMethodInfoPtr_FlagTest_Internal_Static_Boolean_MessageEnum_MessageEnum_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x0010ED1C File Offset: 0x0010CF1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215770, RefRangeEnd = 215771, XrefRangeStart = 215769, XrefRangeEnd = 215770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteStringWithCode(string value, __BinaryWriter sout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sout);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOUtil.NativeMethodInfoPtr_WriteStringWithCode_Internal_Static_Void_String___BinaryWriter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x0010ED64 File Offset: 0x0010CF64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215783, RefRangeEnd = 215784, XrefRangeStart = 215771, XrefRangeEnd = 215783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteWithCode(Type type, Object value, __BinaryWriter sout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sout);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOUtil.NativeMethodInfoPtr_WriteWithCode_Internal_Static_Void_Type_Object___BinaryWriter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x00013B85 File Offset: 0x00011D85
		public IOUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002EA3 RID: 11939
		private static readonly IntPtr NativeMethodInfoPtr_FlagTest_Internal_Static_Boolean_MessageEnum_MessageEnum_0;

		// Token: 0x04002EA4 RID: 11940
		private static readonly IntPtr NativeMethodInfoPtr_WriteStringWithCode_Internal_Static_Void_String___BinaryWriter_0;

		// Token: 0x04002EA5 RID: 11941
		private static readonly IntPtr NativeMethodInfoPtr_WriteWithCode_Internal_Static_Void_Type_Object___BinaryWriter_0;
	}
}
