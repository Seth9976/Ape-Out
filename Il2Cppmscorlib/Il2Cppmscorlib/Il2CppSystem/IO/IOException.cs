using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x02000209 RID: 521
	[Serializable]
	public class IOException : SystemException
	{
		// Token: 0x06002185 RID: 8581 RVA: 0x000BB738 File Offset: 0x000B9938
		// Note: this type is marked as 'beforefieldinit'.
		static IOException()
		{
			Il2CppClassPointerStore<IOException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "IOException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOException>.NativeClassPtr);
			IOException.NativeFieldInfoPtr__maybeFullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOException>.NativeClassPtr, "_maybeFullPath");
			IOException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOException>.NativeClassPtr, 100668924);
			IOException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOException>.NativeClassPtr, 100668925);
			IOException.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOException>.NativeClassPtr, 100668926);
			IOException.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOException>.NativeClassPtr, 100668927);
			IOException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOException>.NativeClassPtr, 100668928);
			IOException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOException>.NativeClassPtr, 100668929);
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x000BB7F4 File Offset: 0x000B99F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190581, RefRangeEnd = 190582, XrefRangeStart = 190578, XrefRangeEnd = 190581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x000BB830 File Offset: 0x000B9A30
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 190583, RefRangeEnd = 190589, XrefRangeStart = 190582, XrefRangeEnd = 190583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x000BB87C File Offset: 0x000B9A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190589, XrefRangeEnd = 190590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOException(string message, int hresult)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hresult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOException.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x000BB8D8 File Offset: 0x000B9AD8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 190591, RefRangeEnd = 190597, XrefRangeStart = 190590, XrefRangeEnd = 190591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOException(string message, int hresult, string maybeFullPath)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hresult;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(maybeFullPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOException.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x000BB944 File Offset: 0x000B9B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190597, XrefRangeEnd = 190598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x000BB9A4 File Offset: 0x000B9BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x0000B368 File Offset: 0x00009568
		public IOException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x0600218D RID: 8589 RVA: 0x000BBA08 File Offset: 0x000B9C08
		// (set) Token: 0x0600218E RID: 8590 RVA: 0x0000B371 File Offset: 0x00009571
		public unsafe string _maybeFullPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOException.NativeFieldInfoPtr__maybeFullPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOException.NativeFieldInfoPtr__maybeFullPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001E2C RID: 7724
		private static readonly IntPtr NativeFieldInfoPtr__maybeFullPath;

		// Token: 0x04001E2D RID: 7725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E2E RID: 7726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001E2F RID: 7727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

		// Token: 0x04001E30 RID: 7728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_String_0;

		// Token: 0x04001E31 RID: 7729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04001E32 RID: 7730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
