using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppDG.Tweening.Core
{
	// Token: 0x02000049 RID: 73
	public sealed class DOGetter<T> : MulticastDelegate
	{
		// Token: 0x06000463 RID: 1123 RVA: 0x0001ADE8 File Offset: 0x00018FE8
		// Note: this type is marked as 'beforefieldinit'.
		static DOGetter()
		{
			Il2CppClassPointerStore<DOGetter<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "DOGetter`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			DOGetter<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOGetter<T>>.NativeClassPtr, 100664168);
			DOGetter<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOGetter<T>>.NativeClassPtr, 100664169);
			DOGetter<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOGetter<T>>.NativeClassPtr, 100664170);
			DOGetter<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_T_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOGetter<T>>.NativeClassPtr, 100664171);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0001AE9C File Offset: 0x0001909C
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DOGetter(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOGetter<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOGetter<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0001AEF8 File Offset: 0x000190F8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 124154, RefRangeEnd = 124168, XrefRangeStart = 124154, XrefRangeEnd = 124154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOGetter<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0001AF34 File Offset: 0x00019134
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOGetter<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0001AF98 File Offset: 0x00019198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124168, XrefRangeEnd = 124169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOGetter<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_T_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00003629 File Offset: 0x00001829
		public DOGetter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00003632 File Offset: 0x00001832
		public static implicit operator DOGetter<T>(Func<T> A_0)
		{
			return DelegateSupport.ConvertDelegate<DOGetter<T>>(A_0);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000363A File Offset: 0x0000183A
		public static DOGetter<T>operator +(DOGetter<T> A_0, DOGetter<T> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<DOGetter<T>>();
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00003648 File Offset: 0x00001848
		public static DOGetter<T>operator -(DOGetter<T> A_0, DOGetter<T> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<DOGetter<T>>();
			}
			return delegate2;
		}

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_T_0;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_T_IAsyncResult_0;
	}
}
