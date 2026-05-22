using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace Il2CppSystem.Net.Security
{
	// Token: 0x0200015A RID: 346
	public class AuthenticatedStream : Stream
	{
		// Token: 0x06001647 RID: 5703 RVA: 0x00064718 File Offset: 0x00062918
		// Note: this type is marked as 'beforefieldinit'.
		static AuthenticatedStream()
		{
			Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Security", "AuthenticatedStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr);
			AuthenticatedStream.NativeFieldInfoPtr__InnerStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr, "_InnerStream");
			AuthenticatedStream.NativeFieldInfoPtr__LeaveStreamOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr, "_LeaveStreamOpen");
			AuthenticatedStream.NativeMethodInfoPtr__ctor_Protected_Void_Stream_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr, 100666460);
			AuthenticatedStream.NativeMethodInfoPtr_get_InnerStream_Protected_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr, 100666461);
			AuthenticatedStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr, 100666462);
			AuthenticatedStream.NativeMethodInfoPtr_get_IsAuthenticated_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr, 100666463);
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x000647C0 File Offset: 0x000629C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 388377, RefRangeEnd = 388381, XrefRangeStart = 388368, XrefRangeEnd = 388377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveInnerStreamOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatedStream.NativeMethodInfoPtr__ctor_Protected_Void_Stream_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06001649 RID: 5705 RVA: 0x0006481C File Offset: 0x00062A1C
		public unsafe Stream InnerStream
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatedStream.NativeMethodInfoPtr_get_InnerStream_Protected_get_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x0006485C File Offset: 0x00062A5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 388383, RefRangeEnd = 388387, XrefRangeStart = 388381, XrefRangeEnd = 388383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AuthenticatedStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x000648A8 File Offset: 0x00062AA8
		public unsafe virtual bool IsAuthenticated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AuthenticatedStream.NativeMethodInfoPtr_get_IsAuthenticated_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x0000B1D6 File Offset: 0x000093D6
		public AuthenticatedStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x0600164D RID: 5709 RVA: 0x000648F0 File Offset: 0x00062AF0
		// (set) Token: 0x0600164E RID: 5710 RVA: 0x0000B1DF File Offset: 0x000093DF
		public unsafe Stream _InnerStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatedStream.NativeFieldInfoPtr__InnerStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatedStream.NativeFieldInfoPtr__InnerStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x00064920 File Offset: 0x00062B20
		// (set) Token: 0x06001650 RID: 5712 RVA: 0x0000B1FE File Offset: 0x000093FE
		public unsafe bool _LeaveStreamOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatedStream.NativeFieldInfoPtr__LeaveStreamOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatedStream.NativeFieldInfoPtr__LeaveStreamOpen)) = value;
			}
		}

		// Token: 0x040011D7 RID: 4567
		private static readonly IntPtr NativeFieldInfoPtr__InnerStream;

		// Token: 0x040011D8 RID: 4568
		private static readonly IntPtr NativeFieldInfoPtr__LeaveStreamOpen;

		// Token: 0x040011D9 RID: 4569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Stream_Boolean_0;

		// Token: 0x040011DA RID: 4570
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerStream_Protected_get_Stream_0;

		// Token: 0x040011DB RID: 4571
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040011DC RID: 4572
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAuthenticated_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
