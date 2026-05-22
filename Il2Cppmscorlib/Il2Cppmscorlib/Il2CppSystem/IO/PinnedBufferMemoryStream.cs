using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.IO
{
	// Token: 0x0200020C RID: 524
	public sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream
	{
		// Token: 0x060021CA RID: 8650 RVA: 0x000BCB30 File Offset: 0x000BAD30
		// Note: this type is marked as 'beforefieldinit'.
		static PinnedBufferMemoryStream()
		{
			Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "PinnedBufferMemoryStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr);
			PinnedBufferMemoryStream.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr, "_array");
			PinnedBufferMemoryStream.NativeFieldInfoPtr__pinningHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr, "_pinningHandle");
			PinnedBufferMemoryStream.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr, 100668965);
			PinnedBufferMemoryStream.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr, 100668966);
			PinnedBufferMemoryStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr, 100668967);
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x000BCBC4 File Offset: 0x000BADC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190716, XrefRangeEnd = 190727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PinnedBufferMemoryStream(Il2CppStructArray<byte> array)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinnedBufferMemoryStream.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x000BCC10 File Offset: 0x000BAE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190727, XrefRangeEnd = 190728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinnedBufferMemoryStream.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x000BCC44 File Offset: 0x000BAE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190728, XrefRangeEnd = 190729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinnedBufferMemoryStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x0000B4B8 File Offset: 0x000096B8
		public PinnedBufferMemoryStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x000BCC84 File Offset: 0x000BAE84
		// (set) Token: 0x060021D0 RID: 8656 RVA: 0x0000B4C1 File Offset: 0x000096C1
		public unsafe Il2CppStructArray<byte> _array
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinnedBufferMemoryStream.NativeFieldInfoPtr__array);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinnedBufferMemoryStream.NativeFieldInfoPtr__array), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x000BCCB4 File Offset: 0x000BAEB4
		// (set) Token: 0x060021D2 RID: 8658 RVA: 0x0000B4E0 File Offset: 0x000096E0
		public unsafe GCHandle _pinningHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinnedBufferMemoryStream.NativeFieldInfoPtr__pinningHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinnedBufferMemoryStream.NativeFieldInfoPtr__pinningHandle)) = value;
			}
		}

		// Token: 0x04001E60 RID: 7776
		private static readonly IntPtr NativeFieldInfoPtr__array;

		// Token: 0x04001E61 RID: 7777
		private static readonly IntPtr NativeFieldInfoPtr__pinningHandle;

		// Token: 0x04001E62 RID: 7778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001E63 RID: 7779
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001E64 RID: 7780
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
	}
}
