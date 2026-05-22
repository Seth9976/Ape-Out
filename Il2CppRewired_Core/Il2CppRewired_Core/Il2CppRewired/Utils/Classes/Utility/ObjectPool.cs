using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x02000209 RID: 521
	public class ObjectPool<T> : Object where T : class
	{
		// Token: 0x0600363E RID: 13886 RVA: 0x0010CA1C File Offset: 0x0010AC1C
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectPool()
		{
			Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "ObjectPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr);
			ObjectPool<T>.NativeFieldInfoPtr__pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "_pool");
			ObjectPool<T>.NativeFieldInfoPtr__createInstanceDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "_createInstanceDelegate");
			ObjectPool<T>.NativeFieldInfoPtr__processOnReturnDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "_processOnReturnDelegate");
			ObjectPool<T>.NativeFieldInfoPtr_MMpmgMlCJDAnHJjLOhQlrlwLWAa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "MMpmgMlCJDAnHJjLOhQlrlwLWAa");
			ObjectPool<T>.NativeMethodInfoPtr_get_InstanceCount_Protected_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100676702);
			ObjectPool<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_1_T_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100676703);
			ObjectPool<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100676704);
			ObjectPool<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100676705);
			ObjectPool<T>.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100676706);
			ObjectPool<T>.NativeMethodInfoPtr_Return_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100676707);
			ObjectPool<T>.NativeMethodInfoPtr_QnqGcbLnZDunWHMaNlACFwNbUkZ_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100676708);
			ObjectPool<T>.NativeMethodInfoPtr_GuiaPzRPcUkKxVCBuCjZrhqxEjy_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100676709);
			ObjectPool<T>.NativeMethodInfoPtr_CreateInstance_Protected_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100676710);
			ObjectPool<T>.NativeMethodInfoPtr_IncrementInstanceCount_Protected_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100676711);
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x0600363F RID: 13887 RVA: 0x0010CBA0 File Offset: 0x0010ADA0
		public unsafe ulong InstanceCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_get_InstanceCount_Protected_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x0010CBDC File Offset: 0x0010ADDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346673, RefRangeEnd = 346674, XrefRangeStart = 346668, XrefRangeEnd = 346673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectPool(int startingSize, Func<T> createInstanceDelegate, Action<T> processOnReturnDelegate = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startingSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createInstanceDelegate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(processOnReturnDelegate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_1_T_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x0010CC48 File Offset: 0x0010AE48
		[CallerCount(0)]
		public unsafe ObjectPool(Func<T> instancerDelegate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instancerDelegate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x0010CC94 File Offset: 0x0010AE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346674, XrefRangeEnd = 346678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear(bool reduceSize = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reduceSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x0010CCD4 File Offset: 0x0010AED4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346693, RefRangeEnd = 346695, XrefRangeStart = 346678, XrefRangeEnd = 346693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x0010CD10 File Offset: 0x0010AF10
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 346708, RefRangeEnd = 346728, XrefRangeStart = 346695, XrefRangeEnd = 346708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Return(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = item;
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
					ptr4 = ref item;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Return_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x0010CDA8 File Offset: 0x0010AFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object QnqGcbLnZDunWHMaNlACFwNbUkZ()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_QnqGcbLnZDunWHMaNlACFwNbUkZ_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x0010CDE8 File Offset: 0x0010AFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346728, XrefRangeEnd = 346735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GuiaPzRPcUkKxVCBuCjZrhqxEjy(Object A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_GuiaPzRPcUkKxVCBuCjZrhqxEjy_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x0010CE38 File Offset: 0x0010B038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346735, XrefRangeEnd = 346744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T CreateInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_CreateInstance_Protected_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x0010CE74 File Offset: 0x0010B074
		[CallerCount(0)]
		public unsafe ulong IncrementInstanceCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_IncrementInstanceCount_Protected_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x00012BD6 File Offset: 0x00010DD6
		public ObjectPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x0600364A RID: 13898 RVA: 0x0010CEB0 File Offset: 0x0010B0B0
		// (set) Token: 0x0600364B RID: 13899 RVA: 0x00012BDF File Offset: 0x00010DDF
		public unsafe Queue<T> _pool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr__pool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr__pool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x0600364C RID: 13900 RVA: 0x0010CEE0 File Offset: 0x0010B0E0
		// (set) Token: 0x0600364D RID: 13901 RVA: 0x00012BFE File Offset: 0x00010DFE
		public unsafe Func<T> _createInstanceDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr__createInstanceDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr__createInstanceDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x0600364E RID: 13902 RVA: 0x0010CF10 File Offset: 0x0010B110
		// (set) Token: 0x0600364F RID: 13903 RVA: 0x00012C1D File Offset: 0x00010E1D
		public unsafe Action<T> _processOnReturnDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr__processOnReturnDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr__processOnReturnDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06003650 RID: 13904 RVA: 0x0010CF40 File Offset: 0x0010B140
		// (set) Token: 0x06003651 RID: 13905 RVA: 0x00012C3C File Offset: 0x00010E3C
		public unsafe ulong MMpmgMlCJDAnHJjLOhQlrlwLWAa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_MMpmgMlCJDAnHJjLOhQlrlwLWAa);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_MMpmgMlCJDAnHJjLOhQlrlwLWAa)) = value;
			}
		}

		// Token: 0x04002E04 RID: 11780
		private static readonly IntPtr NativeFieldInfoPtr__pool;

		// Token: 0x04002E05 RID: 11781
		private static readonly IntPtr NativeFieldInfoPtr__createInstanceDelegate;

		// Token: 0x04002E06 RID: 11782
		private static readonly IntPtr NativeFieldInfoPtr__processOnReturnDelegate;

		// Token: 0x04002E07 RID: 11783
		private static readonly IntPtr NativeFieldInfoPtr_MMpmgMlCJDAnHJjLOhQlrlwLWAa;

		// Token: 0x04002E08 RID: 11784
		private static readonly IntPtr NativeMethodInfoPtr_get_InstanceCount_Protected_get_UInt64_0;

		// Token: 0x04002E09 RID: 11785
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_1_T_Action_1_T_0;

		// Token: 0x04002E0A RID: 11786
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_0;

		// Token: 0x04002E0B RID: 11787
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_Boolean_0;

		// Token: 0x04002E0C RID: 11788
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_0;

		// Token: 0x04002E0D RID: 11789
		private static readonly IntPtr NativeMethodInfoPtr_Return_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x04002E0E RID: 11790
		private static readonly IntPtr NativeMethodInfoPtr_QnqGcbLnZDunWHMaNlACFwNbUkZ_Private_Virtual_Final_New_Object_0;

		// Token: 0x04002E0F RID: 11791
		private static readonly IntPtr NativeMethodInfoPtr_GuiaPzRPcUkKxVCBuCjZrhqxEjy_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04002E10 RID: 11792
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Protected_T_0;

		// Token: 0x04002E11 RID: 11793
		private static readonly IntPtr NativeMethodInfoPtr_IncrementInstanceCount_Protected_UInt64_0;
	}
}
