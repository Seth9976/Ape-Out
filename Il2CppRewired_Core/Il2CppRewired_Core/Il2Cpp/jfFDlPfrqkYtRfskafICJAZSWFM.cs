using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001D7 RID: 471
	public static class jfFDlPfrqkYtRfskafICJAZSWFM : global::Il2CppSystem.Object
	{
		// Token: 0x060030CE RID: 12494 RVA: 0x000F2CC4 File Offset: 0x000F0EC4
		// Note: this type is marked as 'beforefieldinit'.
		static jfFDlPfrqkYtRfskafICJAZSWFM()
		{
			Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "", "jfFDlPfrqkYtRfskafICJAZSWFM");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM>.NativeClassPtr);
			jfFDlPfrqkYtRfskafICJAZSWFM.NativeMethodInfoPtr_uQcBaWmjldogcVbgLMloyUrlduB_Public_Static_Void_T_TArgs_EventFunction_2_T_TArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM>.NativeClassPtr, 100675735);
			jfFDlPfrqkYtRfskafICJAZSWFM.NativeMethodInfoPtr_uQcBaWmjldogcVbgLMloyUrlduB_Public_Static_Void_IList_1_T_TArgs_EventFunction_2_T_TArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM>.NativeClassPtr, 100675736);
			jfFDlPfrqkYtRfskafICJAZSWFM.NativeMethodInfoPtr_TyJGANkMZNmBrRGjqJpZXMOJjjPf_Public_Static_Void_IList_1_T_TArgs_EventFunction_2_T_TArgs_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM>.NativeClassPtr, 100675737);
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x000F2D30 File Offset: 0x000F0F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335651, XrefRangeEnd = 335657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void uQcBaWmjldogcVbgLMloyUrlduB<T, TArgs>(T A_0, TArgs A_1, jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs> A_2) where T : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = A_0;
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
					ptr4 = ref A_0;
				}
				*ptr2 = ref ptr4;
			}
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref TArgs ptr7;
			if (!typeof(TArgs).IsValueType)
			{
				TArgs targs = A_1;
				if (!(targs is string))
				{
					ref TArgs ptr6 = (ptr7 = IL2CPP.Il2CppObjectBaseToPtr(targs as Il2CppObjectBase));
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
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(targs as string);
				}
			}
			else
			{
				ptr7 = ref A_1;
			}
			*ptr5 = ref ptr7;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(jfFDlPfrqkYtRfskafICJAZSWFM.MethodInfoStoreGeneric_uQcBaWmjldogcVbgLMloyUrlduB_Public_Static_Void_T_TArgs_EventFunction_2_T_TArgs_0<T, TArgs>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x000F2E20 File Offset: 0x000F1020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335657, XrefRangeEnd = 335668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void uQcBaWmjldogcVbgLMloyUrlduB<T, TArgs>(IList<T> A_0, TArgs A_1, jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs> A_2) where T : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref TArgs ptr4;
			if (!typeof(TArgs).IsValueType)
			{
				TArgs targs = A_1;
				if (!(targs is string))
				{
					ref TArgs ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(targs as Il2CppObjectBase));
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(targs as string);
				}
			}
			else
			{
				ptr4 = ref A_1;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(jfFDlPfrqkYtRfskafICJAZSWFM.MethodInfoStoreGeneric_uQcBaWmjldogcVbgLMloyUrlduB_Public_Static_Void_IList_1_T_TArgs_EventFunction_2_T_TArgs_0<T, TArgs>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x000F2EC8 File Offset: 0x000F10C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335668, XrefRangeEnd = 335696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TyJGANkMZNmBrRGjqJpZXMOJjjPf<T, TArgs>(IList<T> A_0, TArgs A_1, jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs> A_2, bool A_3) where T : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref TArgs ptr4;
			if (!typeof(TArgs).IsValueType)
			{
				TArgs targs = A_1;
				if (!(targs is string))
				{
					ref TArgs ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(targs as Il2CppObjectBase));
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(targs as string);
				}
			}
			else
			{
				ptr4 = ref A_1;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(jfFDlPfrqkYtRfskafICJAZSWFM.MethodInfoStoreGeneric_TyJGANkMZNmBrRGjqJpZXMOJjjPf_Public_Static_Void_IList_1_T_TArgs_EventFunction_2_T_TArgs_Boolean_0<T, TArgs>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x00011864 File Offset: 0x0000FA64
		public jfFDlPfrqkYtRfskafICJAZSWFM(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040029A9 RID: 10665
		private static readonly IntPtr NativeMethodInfoPtr_uQcBaWmjldogcVbgLMloyUrlduB_Public_Static_Void_T_TArgs_EventFunction_2_T_TArgs_0;

		// Token: 0x040029AA RID: 10666
		private static readonly IntPtr NativeMethodInfoPtr_uQcBaWmjldogcVbgLMloyUrlduB_Public_Static_Void_IList_1_T_TArgs_EventFunction_2_T_TArgs_0;

		// Token: 0x040029AB RID: 10667
		private static readonly IntPtr NativeMethodInfoPtr_TyJGANkMZNmBrRGjqJpZXMOJjjPf_Public_Static_Void_IList_1_T_TArgs_EventFunction_2_T_TArgs_Boolean_0;

		// Token: 0x020003F1 RID: 1009
		public sealed class EventFunction<T, TArgs> : MulticastDelegate where T : class
		{
			// Token: 0x06005087 RID: 20615 RVA: 0x0016DED4 File Offset: 0x0016C0D4
			// Note: this type is marked as 'beforefieldinit'.
			static EventFunction()
			{
				Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM>.NativeClassPtr, "EventFunction`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArgs>.NativeClassPtr))
				})).TypeHandle.value);
				jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs>>.NativeClassPtr, 100675738);
				jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_TArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs>>.NativeClassPtr, 100675739);
				jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_TArgs_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs>>.NativeClassPtr, 100675740);
				jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs>>.NativeClassPtr, 100675741);
			}

			// Token: 0x06005088 RID: 20616 RVA: 0x0016DF94 File Offset: 0x0016C194
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventFunction(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005089 RID: 20617 RVA: 0x0016DFF0 File Offset: 0x0016C1F0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 204156, RefRangeEnd = 204159, XrefRangeStart = 204156, XrefRangeEnd = 204159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(T handler, TArgs value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = handler;
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
						ptr4 = ref handler;
					}
					*ptr2 = ref ptr4;
				}
				IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
				ref TArgs ptr7;
				if (!typeof(TArgs).IsValueType)
				{
					TArgs targs = value;
					if (!(targs is string))
					{
						ref TArgs ptr6 = (ptr7 = IL2CPP.Il2CppObjectBaseToPtr(targs as Il2CppObjectBase));
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
						ptr7 = IL2CPP.ManagedStringToIl2Cpp(targs as string);
					}
				}
				else
				{
					ptr7 = ref value;
				}
				*ptr5 = ref ptr7;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_TArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600508A RID: 20618 RVA: 0x0016E0DC File Offset: 0x0016C2DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335635, XrefRangeEnd = 335639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(T handler, TArgs value, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = handler;
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
						ptr4 = ref handler;
					}
					*ptr2 = ref ptr4;
				}
				IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
				ref TArgs ptr7;
				if (!typeof(TArgs).IsValueType)
				{
					TArgs targs = value;
					if (!(targs is string))
					{
						ref TArgs ptr6 = (ptr7 = IL2CPP.Il2CppObjectBaseToPtr(targs as Il2CppObjectBase));
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
						ptr7 = IL2CPP.ManagedStringToIl2Cpp(targs as string);
					}
				}
				else
				{
					ptr7 = ref value;
				}
				*ptr5 = ref ptr7;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_TArgs_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600508B RID: 20619 RVA: 0x0016E1FC File Offset: 0x0016C3FC
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600508C RID: 20620 RVA: 0x0001D4D8 File Offset: 0x0001B6D8
			public EventFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600508D RID: 20621 RVA: 0x0001D4E1 File Offset: 0x0001B6E1
			public static implicit operator jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs>(Action<T, TArgs> A_0)
			{
				return DelegateSupport.ConvertDelegate<jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs>>(A_0);
			}

			// Token: 0x0600508E RID: 20622 RVA: 0x0001D4E9 File Offset: 0x0001B6E9
			public static jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs>operator +(jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs> A_0, jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs> A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs>>();
			}

			// Token: 0x0600508F RID: 20623 RVA: 0x0001D4F7 File Offset: 0x0001B6F7
			public static jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs>operator -(jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs> A_0, jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs> A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<T, TArgs>>();
				}
				return delegate2;
			}

			// Token: 0x0400431B RID: 17179
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400431C RID: 17180
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_TArgs_0;

			// Token: 0x0400431D RID: 17181
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_TArgs_AsyncCallback_Object_0;

			// Token: 0x0400431E RID: 17182
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003F2 RID: 1010
		public class HierarchyEventHelper<THandler, TValue> : global::Il2CppSystem.Object where THandler : class
		{
			// Token: 0x06005090 RID: 20624 RVA: 0x0016E240 File Offset: 0x0016C440
			// Note: this type is marked as 'beforefieldinit'.
			static HierarchyEventHelper()
			{
				Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM>.NativeClassPtr, "HierarchyEventHelper`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<THandler>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>>.NativeClassPtr);
				jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>.NativeFieldInfoPtr_gnSdomQBLbBLXttSDkdEjaGvUUz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>>.NativeClassPtr, "gnSdomQBLbBLXttSDkdEjaGvUUz");
				jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>.NativeFieldInfoPtr_MQJhZlqmBdICcwQNcoSvRHwctKW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>>.NativeClassPtr, "MQJhZlqmBdICcwQNcoSvRHwctKW");
				jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>.NativeFieldInfoPtr_WDfBMDzALIJTjNQipMfecPvKlPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>>.NativeClassPtr, "WDfBMDzALIJTjNQipMfecPvKlPI");
				jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>.NativeMethodInfoPtr__ctor_Public_Void_EventFunction_2_THandler_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>>.NativeClassPtr, 100675742);
				jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>.NativeMethodInfoPtr__ctor_Public_Void_EventFunction_2_THandler_TValue_QkzjVMqDgcaTImwMncnaiIBnmWY_THandler_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>>.NativeClassPtr, 100675743);
				jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>.NativeMethodInfoPtr_ExecuteOnAll_Public_Void_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>>.NativeClassPtr, 100675744);
				jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>.NativeMethodInfoPtr_GetHandlers_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>>.NativeClassPtr, 100675745);
			}

			// Token: 0x06005091 RID: 20625 RVA: 0x0016E344 File Offset: 0x0016C544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335639, XrefRangeEnd = 335640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HierarchyEventHelper(jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<THandler, TValue> executeDelegate)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(executeDelegate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>.NativeMethodInfoPtr__ctor_Public_Void_EventFunction_2_THandler_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005092 RID: 20626 RVA: 0x0016E390 File Offset: 0x0016C590
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335640, XrefRangeEnd = 335642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HierarchyEventHelper(jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<THandler, TValue> executeDelegate, jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>.QkzjVMqDgcaTImwMncnaiIBnmWY executeOn)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(executeDelegate);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref executeOn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>.NativeMethodInfoPtr__ctor_Public_Void_EventFunction_2_THandler_TValue_QkzjVMqDgcaTImwMncnaiIBnmWY_THandler_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005093 RID: 20627 RVA: 0x0016E3EC File Offset: 0x0016C5EC
			[CallerCount(0)]
			public unsafe void ExecuteOnAll(TValue value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref TValue ptr4;
					if (!typeof(TValue).IsValueType)
					{
						TValue tvalue = value;
						if (!(tvalue is string))
						{
							ref TValue ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
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
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(tvalue as string);
						}
					}
					else
					{
						ptr4 = ref value;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>.NativeMethodInfoPtr_ExecuteOnAll_Public_Void_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005094 RID: 20628 RVA: 0x0016E47C File Offset: 0x0016C67C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 335649, RefRangeEnd = 335651, XrefRangeStart = 335642, XrefRangeEnd = 335649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetHandlers(Transform transform)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>.NativeMethodInfoPtr_GetHandlers_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005095 RID: 20629 RVA: 0x0001D508 File Offset: 0x0001B708
			public HierarchyEventHelper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018F7 RID: 6391
			// (get) Token: 0x06005096 RID: 20630 RVA: 0x0016E4C0 File Offset: 0x0016C6C0
			// (set) Token: 0x06005097 RID: 20631 RVA: 0x0001D511 File Offset: 0x0001B711
			public unsafe jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<THandler, TValue> gnSdomQBLbBLXttSDkdEjaGvUUz
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>.NativeFieldInfoPtr_gnSdomQBLbBLXttSDkdEjaGvUUz);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<THandler, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>.NativeFieldInfoPtr_gnSdomQBLbBLXttSDkdEjaGvUUz), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018F8 RID: 6392
			// (get) Token: 0x06005098 RID: 20632 RVA: 0x0016E4F0 File Offset: 0x0016C6F0
			// (set) Token: 0x06005099 RID: 20633 RVA: 0x0001D530 File Offset: 0x0001B730
			public unsafe List<THandler> MQJhZlqmBdICcwQNcoSvRHwctKW
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>.NativeFieldInfoPtr_MQJhZlqmBdICcwQNcoSvRHwctKW);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<THandler>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>.NativeFieldInfoPtr_MQJhZlqmBdICcwQNcoSvRHwctKW), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018F9 RID: 6393
			// (get) Token: 0x0600509A RID: 20634 RVA: 0x0016E520 File Offset: 0x0016C720
			// (set) Token: 0x0600509B RID: 20635 RVA: 0x0001D54F File Offset: 0x0001B74F
			public unsafe jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>.QkzjVMqDgcaTImwMncnaiIBnmWY WDfBMDzALIJTjNQipMfecPvKlPI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>.NativeFieldInfoPtr_WDfBMDzALIJTjNQipMfecPvKlPI);
					return *intPtr;
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>.NativeFieldInfoPtr_WDfBMDzALIJTjNQipMfecPvKlPI), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<THandler, TValue>.QkzjVMqDgcaTImwMncnaiIBnmWY>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400431F RID: 17183
			private static readonly IntPtr NativeFieldInfoPtr_gnSdomQBLbBLXttSDkdEjaGvUUz;

			// Token: 0x04004320 RID: 17184
			private static readonly IntPtr NativeFieldInfoPtr_MQJhZlqmBdICcwQNcoSvRHwctKW;

			// Token: 0x04004321 RID: 17185
			private static readonly IntPtr NativeFieldInfoPtr_WDfBMDzALIJTjNQipMfecPvKlPI;

			// Token: 0x04004322 RID: 17186
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventFunction_2_THandler_TValue_0;

			// Token: 0x04004323 RID: 17187
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventFunction_2_THandler_TValue_QkzjVMqDgcaTImwMncnaiIBnmWY_THandler_TValue_0;

			// Token: 0x04004324 RID: 17188
			private static readonly IntPtr NativeMethodInfoPtr_ExecuteOnAll_Public_Void_TValue_0;

			// Token: 0x04004325 RID: 17189
			private static readonly IntPtr NativeMethodInfoPtr_GetHandlers_Public_Void_Transform_0;

			// Token: 0x020005AD RID: 1453
			[OriginalName("Rewired_Core.dll", "", "QkzjVMqDgcaTImwMncnaiIBnmWY")]
			[Flags]
			public enum QkzjVMqDgcaTImwMncnaiIBnmWY
			{
				// Token: 0x04004F8A RID: 20362
				urhBwQidoSAKHIhcxeCWNbALMhkh = 0,
				// Token: 0x04004F8B RID: 20363
				OeMEPKKkbWyjofIKrzWhitPtiiB = 1,
				// Token: 0x04004F8C RID: 20364
				gBUUIiWMkQKeaKCCQjPedkHmLepa = 4,
				// Token: 0x04004F8D RID: 20365
				LVSzPrrgPdGRbIWxSMvBDOzOLfB = 8,
				// Token: 0x04004F8E RID: 20366
				MCsezjsBpEEMuBvptyhjqSxWmBr = -1
			}
		}

		// Token: 0x020003F3 RID: 1011
		private sealed class MethodInfoStoreGeneric_uQcBaWmjldogcVbgLMloyUrlduB_Public_Static_Void_T_TArgs_EventFunction_2_T_TArgs_0<T, TArgs>
		{
			// Token: 0x04004326 RID: 17190
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(jfFDlPfrqkYtRfskafICJAZSWFM.NativeMethodInfoPtr_uQcBaWmjldogcVbgLMloyUrlduB_Public_Static_Void_T_TArgs_EventFunction_2_T_TArgs_0, Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArgs>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003F4 RID: 1012
		private sealed class MethodInfoStoreGeneric_uQcBaWmjldogcVbgLMloyUrlduB_Public_Static_Void_IList_1_T_TArgs_EventFunction_2_T_TArgs_0<T, TArgs>
		{
			// Token: 0x04004327 RID: 17191
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(jfFDlPfrqkYtRfskafICJAZSWFM.NativeMethodInfoPtr_uQcBaWmjldogcVbgLMloyUrlduB_Public_Static_Void_IList_1_T_TArgs_EventFunction_2_T_TArgs_0, Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArgs>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003F5 RID: 1013
		private sealed class MethodInfoStoreGeneric_TyJGANkMZNmBrRGjqJpZXMOJjjPf_Public_Static_Void_IList_1_T_TArgs_EventFunction_2_T_TArgs_Boolean_0<T, TArgs>
		{
			// Token: 0x04004328 RID: 17192
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(jfFDlPfrqkYtRfskafICJAZSWFM.NativeMethodInfoPtr_TyJGANkMZNmBrRGjqJpZXMOJjjPf_Public_Static_Void_IList_1_T_TArgs_EventFunction_2_T_TArgs_Boolean_0, Il2CppClassPointerStore<jfFDlPfrqkYtRfskafICJAZSWFM>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArgs>.NativeClassPtr))
			}))));
		}
	}
}
