using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x0200020A RID: 522
	public sealed class SetAndRestoreVar<T> : ValueType
	{
		// Token: 0x06003652 RID: 13906 RVA: 0x0010CF68 File Offset: 0x0010B168
		// Note: this type is marked as 'beforefieldinit'.
		static SetAndRestoreVar()
		{
			Il2CppClassPointerStore<SetAndRestoreVar<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "SetAndRestoreVar`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAndRestoreVar<T>>.NativeClassPtr);
			SetAndRestoreVar<T>.NativeFieldInfoPtr_oVPVyWUbXVJAVAOdhOFwgOwomNH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAndRestoreVar<T>>.NativeClassPtr, "oVPVyWUbXVJAVAOdhOFwgOwomNH");
			SetAndRestoreVar<T>.NativeFieldInfoPtr_mbKicVgPYEfIpYrRagLVzPvBOCrA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAndRestoreVar<T>>.NativeClassPtr, "mbKicVgPYEfIpYrRagLVzPvBOCrA");
			SetAndRestoreVar<T>.NativeMethodInfoPtr__ctor_Public_Void_T_T_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAndRestoreVar<T>>.NativeClassPtr, 100676712);
			SetAndRestoreVar<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAndRestoreVar<T>>.NativeClassPtr, 100676713);
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x0010D024 File Offset: 0x0010B224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346744, XrefRangeEnd = 346752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetAndRestoreVar(T oldValue, T newValue, Action<T> setValueDelegate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAndRestoreVar<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = oldValue;
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
					ptr4 = ref oldValue;
				}
				*ptr2 = ref ptr4;
			}
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr7;
			if (!typeof(T).IsValueType)
			{
				T t2 = newValue;
				if (!(t2 is string))
				{
					ref T ptr6 = (ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
					if ((ref ptr6) != null)
					{
						ptr7 = ref ptr6;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
						{
							ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
						}
					}
				}
				else
				{
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
				}
			}
			else
			{
				ptr7 = ref newValue;
			}
			*ptr5 = ref ptr7;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setValueDelegate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAndRestoreVar<T>.NativeMethodInfoPtr__ctor_Public_Void_T_T_Action_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x0010D130 File Offset: 0x0010B330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346752, XrefRangeEnd = 346766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAndRestoreVar<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x00012C57 File Offset: 0x00010E57
		public SetAndRestoreVar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x00012C60 File Offset: 0x00010E60
		public SetAndRestoreVar()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAndRestoreVar<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x06003657 RID: 13911 RVA: 0x0010D168 File Offset: 0x0010B368
		// (set) Token: 0x06003658 RID: 13912 RVA: 0x00012C72 File Offset: 0x00010E72
		public unsafe Action<T> oVPVyWUbXVJAVAOdhOFwgOwomNH
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndRestoreVar<T>.NativeFieldInfoPtr_oVPVyWUbXVJAVAOdhOFwgOwomNH);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndRestoreVar<T>.NativeFieldInfoPtr_oVPVyWUbXVJAVAOdhOFwgOwomNH), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x06003659 RID: 13913 RVA: 0x0010D198 File Offset: 0x0010B398
		// (set) Token: 0x0600365A RID: 13914 RVA: 0x0010D1C0 File Offset: 0x0010B3C0
		public unsafe T mbKicVgPYEfIpYrRagLVzPvBOCrA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndRestoreVar<T>.NativeFieldInfoPtr_mbKicVgPYEfIpYrRagLVzPvBOCrA);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndRestoreVar<T>.NativeFieldInfoPtr_mbKicVgPYEfIpYrRagLVzPvBOCrA);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x04002E12 RID: 11794
		private static readonly IntPtr NativeFieldInfoPtr_oVPVyWUbXVJAVAOdhOFwgOwomNH;

		// Token: 0x04002E13 RID: 11795
		private static readonly IntPtr NativeFieldInfoPtr_mbKicVgPYEfIpYrRagLVzPvBOCrA;

		// Token: 0x04002E14 RID: 11796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_T_Action_1_T_0;

		// Token: 0x04002E15 RID: 11797
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
