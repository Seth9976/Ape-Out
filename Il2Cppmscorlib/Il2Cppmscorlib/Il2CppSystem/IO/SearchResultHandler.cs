using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.IO
{
	// Token: 0x02000204 RID: 516
	public class SearchResultHandler<TSource> : Object
	{
		// Token: 0x06002153 RID: 8531 RVA: 0x000BAC38 File Offset: 0x000B8E38
		// Note: this type is marked as 'beforefieldinit'.
		static SearchResultHandler()
		{
			Il2CppClassPointerStore<SearchResultHandler<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "SearchResultHandler`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchResultHandler<TSource>>.NativeClassPtr);
			SearchResultHandler<TSource>.NativeMethodInfoPtr_IsResultIncluded_Internal_Abstract_Virtual_New_Boolean_SearchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchResultHandler<TSource>>.NativeClassPtr, 100668904);
			SearchResultHandler<TSource>.NativeMethodInfoPtr_CreateObject_Internal_Abstract_Virtual_New_TSource_SearchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchResultHandler<TSource>>.NativeClassPtr, 100668905);
			SearchResultHandler<TSource>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchResultHandler<TSource>>.NativeClassPtr, 100668906);
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x000BACE0 File Offset: 0x000B8EE0
		[CallerCount(0)]
		public unsafe virtual bool IsResultIncluded(SearchResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SearchResultHandler<TSource>.NativeMethodInfoPtr_IsResultIncluded_Internal_Abstract_Virtual_New_Boolean_SearchResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x000BAD38 File Offset: 0x000B8F38
		[CallerCount(0)]
		public unsafe virtual TSource CreateObject(SearchResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SearchResultHandler<TSource>.NativeMethodInfoPtr_CreateObject_Internal_Abstract_Virtual_New_TSource_SearchResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
			}
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x000BAD90 File Offset: 0x000B8F90
		[CallerCount(0)]
		public unsafe SearchResultHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SearchResultHandler<TSource>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchResultHandler<TSource>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x0000B215 File Offset: 0x00009415
		public SearchResultHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001E0E RID: 7694
		private static readonly IntPtr NativeMethodInfoPtr_IsResultIncluded_Internal_Abstract_Virtual_New_Boolean_SearchResult_0;

		// Token: 0x04001E0F RID: 7695
		private static readonly IntPtr NativeMethodInfoPtr_CreateObject_Internal_Abstract_Virtual_New_TSource_SearchResult_0;

		// Token: 0x04001E10 RID: 7696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
