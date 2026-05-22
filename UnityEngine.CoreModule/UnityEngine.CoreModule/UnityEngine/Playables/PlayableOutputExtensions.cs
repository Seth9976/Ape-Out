using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Playables
{
	// Token: 0x0200018D RID: 397
	public static class PlayableOutputExtensions : Object
	{
		// Token: 0x06001E64 RID: 7780 RVA: 0x0006F780 File Offset: 0x0006D980
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableOutputExtensions()
		{
			Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableOutputExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr);
			PlayableOutputExtensions.NativeMethodInfoPtr_SetReferenceObject_Public_Static_Void_U_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100666058);
			PlayableOutputExtensions.NativeMethodInfoPtr_SetUserData_Public_Static_Void_U_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100666059);
			PlayableOutputExtensions.NativeMethodInfoPtr_GetSourcePlayable_Public_Static_Playable_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100666060);
			PlayableOutputExtensions.NativeMethodInfoPtr_SetSourcePlayable_Public_Static_Void_U_V_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100666061);
			PlayableOutputExtensions.NativeMethodInfoPtr_GetSourceOutputPort_Public_Static_Int32_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100666062);
			PlayableOutputExtensions.NativeMethodInfoPtr_SetWeight_Public_Static_Void_U_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100666063);
			PlayableOutputExtensions.NativeMethodInfoPtr_PushNotification_Public_Static_Void_U_Playable_INotification_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100666064);
			PlayableOutputExtensions.NativeMethodInfoPtr_AddNotificationReceiver_Public_Static_Void_U_INotificationReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100666065);
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x0006F850 File Offset: 0x0006DA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504021, XrefRangeEnd = 504026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetReferenceObject<U>(this U output, Object value) where U : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = output;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref output;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_SetReferenceObject_Public_Static_Void_U_Object_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x0006F8E4 File Offset: 0x0006DAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504026, XrefRangeEnd = 504031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetUserData<U>(this U output, Object value) where U : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = output;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref output;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_SetUserData_Public_Static_Void_U_Object_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x0006F978 File Offset: 0x0006DB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504031, XrefRangeEnd = 504036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Playable GetSourcePlayable<U>(this U output) where U : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = output;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref output;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_GetSourcePlayable_Public_Static_Playable_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x0006FA04 File Offset: 0x0006DC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504036, XrefRangeEnd = 504041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSourcePlayable<U, V>(this U output, V value, int port) where U : new() where V : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = output;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref output;
				}
				*ptr2 = ref ptr4;
			}
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref V ptr7;
			if (!typeof(V).IsValueType)
			{
				V v = value;
				if (!(v is string))
				{
					ref V ptr6 = (ptr7 = IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase));
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
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(v as string);
				}
			}
			else
			{
				ptr7 = ref value;
			}
			*ptr5 = ref ptr7;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_SetSourcePlayable_Public_Static_Void_U_V_Int32_0<U, V>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x0006FAF0 File Offset: 0x0006DCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504041, XrefRangeEnd = 504046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSourceOutputPort<U>(this U output) where U : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = output;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref output;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_GetSourceOutputPort_Public_Static_Int32_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x0006FB7C File Offset: 0x0006DD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504046, XrefRangeEnd = 504051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetWeight<U>(this U output, float value) where U : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = output;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref output;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_SetWeight_Public_Static_Void_U_Single_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x0006FC0C File Offset: 0x0006DE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504051, XrefRangeEnd = 504056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PushNotification<U>(this U output, Playable origin, INotification notification, Object context = null) where U : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = output;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref output;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(notification);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_PushNotification_Public_Static_Void_U_Playable_INotification_Object_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x0006FCC0 File Offset: 0x0006DEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504056, XrefRangeEnd = 504061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddNotificationReceiver<U>(this U output, INotificationReceiver receiver) where U : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = output;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref output;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(receiver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_AddNotificationReceiver_Public_Static_Void_U_INotificationReceiver_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x0000FF8B File Offset: 0x0000E18B
		public PlayableOutputExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x0006FD54 File Offset: 0x0006DF54
		public static bool IsOutputNull<U>(U output) where U : struct
		{
			return output.GetHandle().IsNull();
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x0006FD7C File Offset: 0x0006DF7C
		public static bool IsOutputValid<U>(U output) where U : struct
		{
			return output.GetHandle().IsValid();
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x0006FDA4 File Offset: 0x0006DFA4
		public static Object GetReferenceObject<U>(U output) where U : struct
		{
			return output.GetHandle().GetReferenceObject();
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x0006FDCC File Offset: 0x0006DFCC
		public static Object GetUserData<U>(U output) where U : struct
		{
			return output.GetHandle().GetUserData();
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x0006FDF4 File Offset: 0x0006DFF4
		public static void SetSourcePlayable<U, V>(U output, V value) where U : struct where V : struct
		{
			output.GetHandle().SetSourcePlayable(value.GetHandle(), output.GetSourceOutputPort<U>());
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x0006FE2C File Offset: 0x0006E02C
		public static float GetWeight<U>(U output) where U : struct
		{
			return output.GetHandle().GetWeight();
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x0006FE54 File Offset: 0x0006E054
		public static Il2CppReferenceArray<INotificationReceiver> GetNotificationReceivers<U>(U output) where U : struct
		{
			return output.GetHandle().GetNotificationReceivers();
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x0006FE7C File Offset: 0x0006E07C
		public static void RemoveNotificationReceiver<U>(U output, INotificationReceiver receiver) where U : struct
		{
			output.GetHandle().RemoveNotificationReceiver(receiver);
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x0006FEA4 File Offset: 0x0006E0A4
		public static int GetSourceInputPort<U>(U output) where U : struct
		{
			return output.GetHandle().GetSourceOutputPort();
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x0000FF94 File Offset: 0x0000E194
		public static void SetSourceInputPort<U>(U output, int value) where U : struct
		{
			output.SetSourcePlayable(output.GetSourcePlayable<U>(), value);
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x0000FFA5 File Offset: 0x0000E1A5
		public static void SetSourceOutputPort<U>(U output, int value) where U : struct
		{
			output.SetSourcePlayable(output.GetSourcePlayable<U>(), value);
		}

		// Token: 0x0400174E RID: 5966
		private static readonly IntPtr NativeMethodInfoPtr_SetReferenceObject_Public_Static_Void_U_Object_0;

		// Token: 0x0400174F RID: 5967
		private static readonly IntPtr NativeMethodInfoPtr_SetUserData_Public_Static_Void_U_Object_0;

		// Token: 0x04001750 RID: 5968
		private static readonly IntPtr NativeMethodInfoPtr_GetSourcePlayable_Public_Static_Playable_U_0;

		// Token: 0x04001751 RID: 5969
		private static readonly IntPtr NativeMethodInfoPtr_SetSourcePlayable_Public_Static_Void_U_V_Int32_0;

		// Token: 0x04001752 RID: 5970
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceOutputPort_Public_Static_Int32_U_0;

		// Token: 0x04001753 RID: 5971
		private static readonly IntPtr NativeMethodInfoPtr_SetWeight_Public_Static_Void_U_Single_0;

		// Token: 0x04001754 RID: 5972
		private static readonly IntPtr NativeMethodInfoPtr_PushNotification_Public_Static_Void_U_Playable_INotification_Object_0;

		// Token: 0x04001755 RID: 5973
		private static readonly IntPtr NativeMethodInfoPtr_AddNotificationReceiver_Public_Static_Void_U_INotificationReceiver_0;

		// Token: 0x02000A34 RID: 2612
		private sealed class MethodInfoStoreGeneric_SetReferenceObject_Public_Static_Void_U_Object_0<U>
		{
			// Token: 0x04001FF7 RID: 8183
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_SetReferenceObject_Public_Static_Void_U_Object_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A35 RID: 2613
		private sealed class MethodInfoStoreGeneric_SetUserData_Public_Static_Void_U_Object_0<U>
		{
			// Token: 0x04001FF8 RID: 8184
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_SetUserData_Public_Static_Void_U_Object_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A36 RID: 2614
		private sealed class MethodInfoStoreGeneric_GetSourcePlayable_Public_Static_Playable_U_0<U>
		{
			// Token: 0x04001FF9 RID: 8185
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_GetSourcePlayable_Public_Static_Playable_U_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A37 RID: 2615
		private sealed class MethodInfoStoreGeneric_SetSourcePlayable_Public_Static_Void_U_V_Int32_0<U, V>
		{
			// Token: 0x04001FFA RID: 8186
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_SetSourcePlayable_Public_Static_Void_U_V_Int32_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A38 RID: 2616
		private sealed class MethodInfoStoreGeneric_GetSourceOutputPort_Public_Static_Int32_U_0<U>
		{
			// Token: 0x04001FFB RID: 8187
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_GetSourceOutputPort_Public_Static_Int32_U_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A39 RID: 2617
		private sealed class MethodInfoStoreGeneric_SetWeight_Public_Static_Void_U_Single_0<U>
		{
			// Token: 0x04001FFC RID: 8188
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_SetWeight_Public_Static_Void_U_Single_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A3A RID: 2618
		private sealed class MethodInfoStoreGeneric_PushNotification_Public_Static_Void_U_Playable_INotification_Object_0<U>
		{
			// Token: 0x04001FFD RID: 8189
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_PushNotification_Public_Static_Void_U_Playable_INotification_Object_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A3B RID: 2619
		private sealed class MethodInfoStoreGeneric_AddNotificationReceiver_Public_Static_Void_U_INotificationReceiver_0<U>
		{
			// Token: 0x04001FFE RID: 8190
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_AddNotificationReceiver_Public_Static_Void_U_INotificationReceiver_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}
	}
}
