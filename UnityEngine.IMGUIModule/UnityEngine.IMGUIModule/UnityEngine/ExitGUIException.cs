using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000016 RID: 22
	public sealed class ExitGUIException : Exception
	{
		// Token: 0x0600047F RID: 1151 RVA: 0x00003B83 File Offset: 0x00001D83
		// Note: this type is marked as 'beforefieldinit'.
		static ExitGUIException()
		{
			Il2CppClassPointerStore<ExitGUIException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "ExitGUIException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExitGUIException>.NativeClassPtr);
			ExitGUIException.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitGUIException>.NativeClassPtr, 100663711);
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00012B14 File Offset: 0x00010D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509689, XrefRangeEnd = 509701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExitGUIException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitGUIException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitGUIException.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00003BBC File Offset: 0x00001DBC
		public ExitGUIException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;
	}
}
