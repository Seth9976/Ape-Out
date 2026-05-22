using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000D0 RID: 208
	public sealed class CastHelper<T> : ValueType
	{
		// Token: 0x06001274 RID: 4724 RVA: 0x0004B0C8 File Offset: 0x000492C8
		// Note: this type is marked as 'beforefieldinit'.
		static CastHelper()
		{
			Il2CppClassPointerStore<CastHelper<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CastHelper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastHelper<T>>.NativeClassPtr);
			CastHelper<T>.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastHelper<T>>.NativeClassPtr, "t");
			CastHelper<T>.NativeFieldInfoPtr_onePointerFurtherThanT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastHelper<T>>.NativeClassPtr, "onePointerFurtherThanT");
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x0000AADF File Offset: 0x00008CDF
		public CastHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		public CastHelper()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastHelper<T>>.NativeClassPtr))
		{
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x0004B15C File Offset: 0x0004935C
		// (set) Token: 0x06001278 RID: 4728 RVA: 0x0004B184 File Offset: 0x00049384
		public unsafe T t
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastHelper<T>.NativeFieldInfoPtr_t);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastHelper<T>.NativeFieldInfoPtr_t);
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

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x0004B22C File Offset: 0x0004942C
		// (set) Token: 0x0600127A RID: 4730 RVA: 0x0000AAFA File Offset: 0x00008CFA
		public unsafe IntPtr onePointerFurtherThanT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastHelper<T>.NativeFieldInfoPtr_onePointerFurtherThanT);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastHelper<T>.NativeFieldInfoPtr_onePointerFurtherThanT)) = value;
			}
		}

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeFieldInfoPtr_t;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeFieldInfoPtr_onePointerFurtherThanT;
	}
}
