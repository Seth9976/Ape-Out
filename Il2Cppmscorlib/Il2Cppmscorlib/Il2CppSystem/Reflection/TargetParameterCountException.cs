using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001BE RID: 446
	[Serializable]
	public sealed class TargetParameterCountException : ApplicationException
	{
		// Token: 0x06001CAD RID: 7341 RVA: 0x000A57C4 File Offset: 0x000A39C4
		// Note: this type is marked as 'beforefieldinit'.
		static TargetParameterCountException()
		{
			Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "TargetParameterCountException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr);
			TargetParameterCountException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr, 100668143);
			TargetParameterCountException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr, 100668144);
			TargetParameterCountException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr, 100668145);
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x000A5830 File Offset: 0x000A3A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186632, XrefRangeEnd = 186635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetParameterCountException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetParameterCountException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x000A586C File Offset: 0x000A3A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186635, XrefRangeEnd = 186636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetParameterCountException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetParameterCountException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x000A58B8 File Offset: 0x000A3AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetParameterCountException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetParameterCountException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x00009BDD File Offset: 0x00007DDD
		public TargetParameterCountException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A6B RID: 6763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001A6C RID: 6764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001A6D RID: 6765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;
	}
}
