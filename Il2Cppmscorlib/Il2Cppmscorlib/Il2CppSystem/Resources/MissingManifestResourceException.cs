using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Resources
{
	// Token: 0x02000181 RID: 385
	[Serializable]
	public class MissingManifestResourceException : SystemException
	{
		// Token: 0x06001AC9 RID: 6857 RVA: 0x0009E4C0 File Offset: 0x0009C6C0
		// Note: this type is marked as 'beforefieldinit'.
		static MissingManifestResourceException()
		{
			Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "MissingManifestResourceException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr);
			MissingManifestResourceException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr, 100667890);
			MissingManifestResourceException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr, 100667891);
			MissingManifestResourceException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr, 100667892);
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x0009E52C File Offset: 0x0009C72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185186, XrefRangeEnd = 185189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingManifestResourceException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingManifestResourceException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x0009E568 File Offset: 0x0009C768
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185190, RefRangeEnd = 185191, XrefRangeStart = 185189, XrefRangeEnd = 185190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingManifestResourceException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingManifestResourceException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x0009E5B4 File Offset: 0x0009C7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingManifestResourceException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingManifestResourceException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x00008FC7 File Offset: 0x000071C7
		public MissingManifestResourceException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400186A RID: 6250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400186B RID: 6251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400186C RID: 6252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
