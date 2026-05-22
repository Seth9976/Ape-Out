using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public class AndroidJavaClass : AndroidJavaObject
	{
		// Token: 0x06000060 RID: 96 RVA: 0x000044B8 File Offset: 0x000026B8
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidJavaClass()
		{
			Il2CppClassPointerStore<AndroidJavaClass>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJavaClass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJavaClass>.NativeClassPtr);
			AndroidJavaClass.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaClass>.NativeClassPtr, 100663340);
			AndroidJavaClass.NativeMethodInfoPtr__AndroidJavaClass_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaClass>.NativeClassPtr, 100663341);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004510 File Offset: 0x00002710
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 481361, RefRangeEnd = 481363, XrefRangeStart = 481357, XrefRangeEnd = 481361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaClass(string className)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidJavaClass>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaClass.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000455C File Offset: 0x0000275C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 481390, RefRangeEnd = 481394, XrefRangeStart = 481363, XrefRangeEnd = 481390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AndroidJavaClass(string className)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaClass.NativeMethodInfoPtr__AndroidJavaClass_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002296 File Offset: 0x00000496
		public AndroidJavaClass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr__AndroidJavaClass_Private_Void_String_0;
	}
}
