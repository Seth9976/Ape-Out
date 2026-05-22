using System;
using Il2CppDG.Tweening.Core.Enums;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppDG.Tweening.Core
{
	// Token: 0x0200004E RID: 78
	public static class Extensions : Object
	{
		// Token: 0x060004DC RID: 1244 RVA: 0x0001C4EC File Offset: 0x0001A6EC
		// Note: this type is marked as 'beforefieldinit'.
		static Extensions()
		{
			Il2CppClassPointerStore<Extensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "Extensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extensions>.NativeClassPtr);
			Extensions.NativeMethodInfoPtr_SetSpecialStartupMode_Public_Static_T_T_SpecialStartupMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100664247);
			Extensions.NativeMethodInfoPtr_Blendable_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100664248);
			Extensions.NativeMethodInfoPtr_NoFrom_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100664249);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0001C558 File Offset: 0x0001A758
		[CallerCount(0)]
		public unsafe static T SetSpecialStartupMode<T>(this T t, SpecialStartupMode mode) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_SetSpecialStartupMode_Public_Static_T_T_SpecialStartupMode_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0001C5F0 File Offset: 0x0001A7F0
		[CallerCount(0)]
		public unsafe static TweenerCore<T1, T2, TPlugOptions> Blendable<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_Blendable_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<T1, T2, TPlugOptions>>(intPtr3) : null;
			}
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0001C634 File Offset: 0x0001A834
		[CallerCount(0)]
		public unsafe static TweenerCore<T1, T2, TPlugOptions> NoFrom<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_NoFrom_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<T1, T2, TPlugOptions>>(intPtr3) : null;
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x000039E4 File Offset: 0x00001BE4
		public Extensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_SetSpecialStartupMode_Public_Static_T_T_SpecialStartupMode_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_Blendable_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_NoFrom_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_0;

		// Token: 0x020000EF RID: 239
		private sealed class MethodInfoStoreGeneric_SetSpecialStartupMode_Public_Static_T_T_SpecialStartupMode_0<T>
		{
			// Token: 0x0400068E RID: 1678
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_SetSpecialStartupMode_Public_Static_T_T_SpecialStartupMode_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000F0 RID: 240
		private sealed class MethodInfoStoreGeneric_Blendable_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>
		{
			// Token: 0x0400068F RID: 1679
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_Blendable_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000F1 RID: 241
		private sealed class MethodInfoStoreGeneric_NoFrom_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000690 RID: 1680
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_NoFrom_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}
	}
}
