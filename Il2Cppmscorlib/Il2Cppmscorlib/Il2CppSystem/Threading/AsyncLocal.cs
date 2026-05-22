using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200026A RID: 618
	public sealed class AsyncLocal<T> : Object
	{
		// Token: 0x06002B24 RID: 11044 RVA: 0x000E0834 File Offset: 0x000DEA34
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncLocal()
		{
			Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "AsyncLocal`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr);
			AsyncLocal<T>.NativeFieldInfoPtr_m_valueChangedHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr, "m_valueChangedHandler");
			AsyncLocal<T>.NativeMethodInfoPtr__ctor_Public_Void_Action_1_AsyncLocalValueChangedArgs_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr, 100670222);
			AsyncLocal<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr, 100670223);
			AsyncLocal<T>.NativeMethodInfoPtr_set_Value_Public_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr, 100670224);
			AsyncLocal<T>.NativeMethodInfoPtr_System_Threading_IAsyncLocal_OnValueChanged_Private_Virtual_Final_New_Void_Object_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr, 100670225);
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x000E0904 File Offset: 0x000DEB04
		[CallerCount(0)]
		public unsafe AsyncLocal(Action<AsyncLocalValueChangedArgs<T>> valueChangedHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueChangedHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncLocal<T>.NativeMethodInfoPtr__ctor_Public_Void_Action_1_AsyncLocalValueChangedArgs_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06002B26 RID: 11046 RVA: 0x000E0950 File Offset: 0x000DEB50
		// (set) Token: 0x06002B27 RID: 11047 RVA: 0x000E098C File Offset: 0x000DEB8C
		public unsafe T Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200997, XrefRangeEnd = 201002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncLocal<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 201006, RefRangeEnd = 201007, XrefRangeStart = 201002, XrefRangeEnd = 201006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						if (!(t is string))
						{
							ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
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
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
						}
					}
					else
					{
						ptr4 = ref value;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncLocal<T>.NativeMethodInfoPtr_set_Value_Public_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x000E0A1C File Offset: 0x000DEC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201007, XrefRangeEnd = 201013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Threading_IAsyncLocal_OnValueChanged(Object previousValueObj, Object currentValueObj, bool contextChanged)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousValueObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentValueObj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contextChanged;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncLocal<T>.NativeMethodInfoPtr_System_Threading_IAsyncLocal_OnValueChanged_Private_Virtual_Final_New_Void_Object_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x0000EE46 File Offset: 0x0000D046
		public AsyncLocal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06002B2A RID: 11050 RVA: 0x000E0A80 File Offset: 0x000DEC80
		// (set) Token: 0x06002B2B RID: 11051 RVA: 0x0000EE4F File Offset: 0x0000D04F
		public unsafe Action<AsyncLocalValueChangedArgs<T>> m_valueChangedHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocal<T>.NativeFieldInfoPtr_m_valueChangedHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncLocalValueChangedArgs<T>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocal<T>.NativeFieldInfoPtr_m_valueChangedHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040025D0 RID: 9680
		private static readonly IntPtr NativeFieldInfoPtr_m_valueChangedHandler;

		// Token: 0x040025D1 RID: 9681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_1_AsyncLocalValueChangedArgs_1_T_0;

		// Token: 0x040025D2 RID: 9682
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_T_0;

		// Token: 0x040025D3 RID: 9683
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_T_0;

		// Token: 0x040025D4 RID: 9684
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IAsyncLocal_OnValueChanged_Private_Virtual_Final_New_Void_Object_Object_Boolean_0;
	}
}
