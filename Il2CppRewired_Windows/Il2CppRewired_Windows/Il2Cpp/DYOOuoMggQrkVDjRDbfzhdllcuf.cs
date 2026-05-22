using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000030 RID: 48
	public sealed class DYOOuoMggQrkVDjRDbfzhdllcuf : MulticastDelegate
	{
		// Token: 0x0600061C RID: 1564 RVA: 0x00020B98 File Offset: 0x0001ED98
		// Note: this type is marked as 'beforefieldinit'.
		static DYOOuoMggQrkVDjRDbfzhdllcuf()
		{
			Il2CppClassPointerStore<DYOOuoMggQrkVDjRDbfzhdllcuf>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "", "DYOOuoMggQrkVDjRDbfzhdllcuf");
			DYOOuoMggQrkVDjRDbfzhdllcuf.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DYOOuoMggQrkVDjRDbfzhdllcuf>.NativeClassPtr, 100664474);
			DYOOuoMggQrkVDjRDbfzhdllcuf.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DYOOuoMggQrkVDjRDbfzhdllcuf>.NativeClassPtr, 100664475);
			DYOOuoMggQrkVDjRDbfzhdllcuf.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DYOOuoMggQrkVDjRDbfzhdllcuf>.NativeClassPtr, 100664476);
			DYOOuoMggQrkVDjRDbfzhdllcuf.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DYOOuoMggQrkVDjRDbfzhdllcuf>.NativeClassPtr, 100664477);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00020C10 File Offset: 0x0001EE10
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DYOOuoMggQrkVDjRDbfzhdllcuf(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DYOOuoMggQrkVDjRDbfzhdllcuf>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DYOOuoMggQrkVDjRDbfzhdllcuf.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00020C6C File Offset: 0x0001EE6C
		[CallerCount(171)]
		[CachedScanResults(RefRangeStart = 1023, RefRangeEnd = 1194, XrefRangeStart = 1023, XrefRangeEnd = 1194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DYOOuoMggQrkVDjRDbfzhdllcuf.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00020CA0 File Offset: 0x0001EEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DYOOuoMggQrkVDjRDbfzhdllcuf.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00020D04 File Offset: 0x0001EF04
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DYOOuoMggQrkVDjRDbfzhdllcuf.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00004C46 File Offset: 0x00002E46
		public DYOOuoMggQrkVDjRDbfzhdllcuf(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00004C4F File Offset: 0x00002E4F
		public static implicit operator DYOOuoMggQrkVDjRDbfzhdllcuf(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<DYOOuoMggQrkVDjRDbfzhdllcuf>(A_0);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00004C57 File Offset: 0x00002E57
		public static DYOOuoMggQrkVDjRDbfzhdllcuf operator +(DYOOuoMggQrkVDjRDbfzhdllcuf A_0, DYOOuoMggQrkVDjRDbfzhdllcuf A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<DYOOuoMggQrkVDjRDbfzhdllcuf>();
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00004C65 File Offset: 0x00002E65
		public static DYOOuoMggQrkVDjRDbfzhdllcuf operator -(DYOOuoMggQrkVDjRDbfzhdllcuf A_0, DYOOuoMggQrkVDjRDbfzhdllcuf A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<DYOOuoMggQrkVDjRDbfzhdllcuf>();
			}
			return delegate2;
		}

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
