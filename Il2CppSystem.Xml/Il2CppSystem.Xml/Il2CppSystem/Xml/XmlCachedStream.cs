using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200009C RID: 156
	public class XmlCachedStream : MemoryStream
	{
		// Token: 0x06000FC5 RID: 4037 RVA: 0x000584E8 File Offset: 0x000566E8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlCachedStream()
		{
			Il2CppClassPointerStore<XmlCachedStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlCachedStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlCachedStream>.NativeClassPtr);
			XmlCachedStream.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlCachedStream>.NativeClassPtr, "uri");
			XmlCachedStream.NativeMethodInfoPtr__ctor_Internal_Void_Uri_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCachedStream>.NativeClassPtr, 100665830);
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00058540 File Offset: 0x00056740
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 402188, RefRangeEnd = 402190, XrefRangeStart = 402182, XrefRangeEnd = 402188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlCachedStream(Uri uri, Stream stream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlCachedStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCachedStream.NativeMethodInfoPtr__ctor_Internal_Void_Uri_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00007398 File Offset: 0x00005598
		public XmlCachedStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x000585A0 File Offset: 0x000567A0
		// (set) Token: 0x06000FC9 RID: 4041 RVA: 0x000073A1 File Offset: 0x000055A1
		public unsafe Uri uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlCachedStream.NativeFieldInfoPtr_uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlCachedStream.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeFieldInfoPtr_uri;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Uri_Stream_0;
	}
}
