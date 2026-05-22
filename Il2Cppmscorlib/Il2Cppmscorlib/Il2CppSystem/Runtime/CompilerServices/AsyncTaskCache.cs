using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000418 RID: 1048
	public static class AsyncTaskCache : Object
	{
		// Token: 0x060042C0 RID: 17088 RVA: 0x00136164 File Offset: 0x00134364
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncTaskCache()
		{
			Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "AsyncTaskCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr);
			AsyncTaskCache.NativeFieldInfoPtr_TrueTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr, "TrueTask");
			AsyncTaskCache.NativeFieldInfoPtr_FalseTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr, "FalseTask");
			AsyncTaskCache.NativeFieldInfoPtr_Int32Tasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr, "Int32Tasks");
			AsyncTaskCache.NativeMethodInfoPtr_CreateInt32Tasks_Private_Static_Il2CppReferenceArray_1_Task_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr, 100673059);
			AsyncTaskCache.NativeMethodInfoPtr_CreateCacheableTask_Internal_Static_Task_1_TResult_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr, 100673060);
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x001361F8 File Offset: 0x001343F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226268, XrefRangeEnd = 226278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Task<int>> CreateInt32Tasks()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskCache.NativeMethodInfoPtr_CreateInt32Tasks_Private_Static_Il2CppReferenceArray_1_Task_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Task<int>>>(intPtr3) : null;
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x0013622C File Offset: 0x0013442C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226278, XrefRangeEnd = 226280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> CreateCacheableTask<TResult>(TResult result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref TResult ptr4;
				if (!typeof(TResult).IsValueType)
				{
					TResult tresult = result;
					if (!(tresult is string))
					{
						ref TResult ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tresult as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(tresult as string);
					}
				}
				else
				{
					ptr4 = ref result;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskCache.MethodInfoStoreGeneric_CreateCacheableTask_Internal_Static_Task_1_TResult_TResult_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x060042C3 RID: 17091 RVA: 0x0001938E File Offset: 0x0001758E
		public AsyncTaskCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x060042C4 RID: 17092 RVA: 0x001362BC File Offset: 0x001344BC
		// (set) Token: 0x060042C5 RID: 17093 RVA: 0x00019397 File Offset: 0x00017597
		public unsafe static Task<bool> TrueTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncTaskCache.NativeFieldInfoPtr_TrueTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncTaskCache.NativeFieldInfoPtr_TrueTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x060042C6 RID: 17094 RVA: 0x001362E4 File Offset: 0x001344E4
		// (set) Token: 0x060042C7 RID: 17095 RVA: 0x000193A9 File Offset: 0x000175A9
		public unsafe static Task<bool> FalseTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncTaskCache.NativeFieldInfoPtr_FalseTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncTaskCache.NativeFieldInfoPtr_FalseTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x060042C8 RID: 17096 RVA: 0x0013630C File Offset: 0x0013450C
		// (set) Token: 0x060042C9 RID: 17097 RVA: 0x000193BB File Offset: 0x000175BB
		public unsafe static Il2CppReferenceArray<Task<int>> Int32Tasks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncTaskCache.NativeFieldInfoPtr_Int32Tasks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Task<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncTaskCache.NativeFieldInfoPtr_Int32Tasks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003668 RID: 13928
		private static readonly IntPtr NativeFieldInfoPtr_TrueTask;

		// Token: 0x04003669 RID: 13929
		private static readonly IntPtr NativeFieldInfoPtr_FalseTask;

		// Token: 0x0400366A RID: 13930
		private static readonly IntPtr NativeFieldInfoPtr_Int32Tasks;

		// Token: 0x0400366B RID: 13931
		private static readonly IntPtr NativeMethodInfoPtr_CreateInt32Tasks_Private_Static_Il2CppReferenceArray_1_Task_1_Int32_0;

		// Token: 0x0400366C RID: 13932
		private static readonly IntPtr NativeMethodInfoPtr_CreateCacheableTask_Internal_Static_Task_1_TResult_TResult_0;

		// Token: 0x0200063D RID: 1597
		private sealed class MethodInfoStoreGeneric_CreateCacheableTask_Internal_Static_Task_1_TResult_TResult_0<TResult>
		{
			// Token: 0x0400456A RID: 17770
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncTaskCache.NativeMethodInfoPtr_CreateCacheableTask_Internal_Static_Task_1_TResult_TResult_0, Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}
	}
}
