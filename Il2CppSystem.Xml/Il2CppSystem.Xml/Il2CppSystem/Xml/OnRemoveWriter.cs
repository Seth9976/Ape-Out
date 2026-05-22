using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000034 RID: 52
	public sealed class OnRemoveWriter : MulticastDelegate
	{
		// Token: 0x060002B1 RID: 689 RVA: 0x0001E4A0 File Offset: 0x0001C6A0
		// Note: this type is marked as 'beforefieldinit'.
		static OnRemoveWriter()
		{
			Il2CppClassPointerStore<OnRemoveWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "OnRemoveWriter");
			OnRemoveWriter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoveWriter>.NativeClassPtr, 100663627);
			OnRemoveWriter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XmlRawWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoveWriter>.NativeClassPtr, 100663628);
			OnRemoveWriter.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XmlRawWriter_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoveWriter>.NativeClassPtr, 100663629);
			OnRemoveWriter.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoveWriter>.NativeClassPtr, 100663630);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0001E518 File Offset: 0x0001C718
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnRemoveWriter(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnRemoveWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnRemoveWriter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0001E574 File Offset: 0x0001C774
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1006, RefRangeEnd = 1022, XrefRangeStart = 1006, XrefRangeEnd = 1022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(XmlRawWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnRemoveWriter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XmlRawWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0001E5B8 File Offset: 0x0001C7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(XmlRawWriter writer, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnRemoveWriter.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XmlRawWriter_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0001E62C File Offset: 0x0001C82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnRemoveWriter.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000030AE File Offset: 0x000012AE
		public OnRemoveWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000030B7 File Offset: 0x000012B7
		public static implicit operator OnRemoveWriter(Action<XmlRawWriter> A_0)
		{
			return DelegateSupport.ConvertDelegate<OnRemoveWriter>(A_0);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000030BF File Offset: 0x000012BF
		public static OnRemoveWriter operator +(OnRemoveWriter A_0, OnRemoveWriter A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<OnRemoveWriter>();
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000030CD File Offset: 0x000012CD
		public static OnRemoveWriter operator -(OnRemoveWriter A_0, OnRemoveWriter A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<OnRemoveWriter>();
			}
			return delegate2;
		}

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XmlRawWriter_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XmlRawWriter_AsyncCallback_Object_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
