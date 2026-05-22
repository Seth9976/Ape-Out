using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001F3 RID: 499
	public static class MiscTools : Object
	{
		// Token: 0x06003310 RID: 13072 RVA: 0x000FED38 File Offset: 0x000FCF38
		// Note: this type is marked as 'beforefieldinit'.
		static MiscTools()
		{
			Il2CppClassPointerStore<MiscTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "MiscTools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiscTools>.NativeClassPtr);
			MiscTools.NativeFieldInfoPtr_ZxobDXMdplWguLNrVegYXtGQfOYC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, "ZxobDXMdplWguLNrVegYXtGQfOYC");
			MiscTools.NativeFieldInfoPtr_AmYJygYpbhYcLRGKhGmgLkvziXy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, "AmYJygYpbhYcLRGKhGmgLkvziXy");
			MiscTools.NativeFieldInfoPtr_geTWCpoeIUBQYIsGqNJsLTYInJbr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, "geTWCpoeIUBQYIsGqNJsLTYInJbr");
			MiscTools.NativeFieldInfoPtr_OEBnDMsbSfiuYcdcspgqRGfpXA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, "OEBnDMsbSfiuYcdcspgqRGfpXA");
			MiscTools.NativeFieldInfoPtr_QESXUmkaDFZhTcvmFGopqNuVapZf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, "QESXUmkaDFZhTcvmFGopqNuVapZf");
			MiscTools.NativeFieldInfoPtr_wBITsuUcSslrrxFpbaoIzmaeaik = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, "wBITsuUcSslrrxFpbaoIzmaeaik");
			MiscTools.NativeMethodInfoPtr_Clone_Public_Static_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676184);
			MiscTools.NativeMethodInfoPtr_Clone_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676185);
			MiscTools.NativeMethodInfoPtr_DeepClone_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676186);
			MiscTools.NativeMethodInfoPtr_DeepClone_Public_Static_T_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676187);
			MiscTools.NativeMethodInfoPtr_DeepClone_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676188);
			MiscTools.NativeMethodInfoPtr_DeepClone_Public_Static_List_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676189);
			MiscTools.NativeMethodInfoPtr_DeepClone_Public_Static_Dictionary_2_TKey_TValue_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676190);
			MiscTools.NativeMethodInfoPtr_CreateGuidHashSHA256_Public_Static_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676191);
			MiscTools.NativeMethodInfoPtr_CreateGuidHashSHA1_Public_Static_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676192);
			MiscTools.NativeMethodInfoPtr_CreateHIDProductGuid_Public_Static_Guid_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676193);
			MiscTools.NativeMethodInfoPtr_Tick_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676194);
			MiscTools.NativeMethodInfoPtr_Tick_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676195);
			MiscTools.NativeMethodInfoPtr_TickPrev_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676196);
			MiscTools.NativeMethodInfoPtr_TickPrev_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676197);
			MiscTools.NativeMethodInfoPtr_IsTickValid_Public_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676198);
			MiscTools.NativeMethodInfoPtr_IsTickValid_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676199);
			MiscTools.NativeMethodInfoPtr_IsTickNewer_Public_Static_Boolean_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676200);
			MiscTools.NativeMethodInfoPtr_IsTickNewer_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676201);
			MiscTools.NativeMethodInfoPtr_IsTickNewerOrEqualTo_Public_Static_Boolean_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676202);
			MiscTools.NativeMethodInfoPtr_IsTickNewerOrEqualTo_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676203);
			MiscTools.NativeMethodInfoPtr_TickDifference_Public_Static_Int64_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676204);
			MiscTools.NativeMethodInfoPtr_TickDifference_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676205);
			MiscTools.NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676206);
			MiscTools.NativeMethodInfoPtr_ToLongUnchecked_Public_Static_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676207);
			MiscTools.NativeMethodInfoPtr_IsValidGuid_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscTools>.NativeClassPtr, 100676208);
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x000FEFD4 File Offset: 0x000FD1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338610, XrefRangeEnd = 338619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Clone(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.NativeMethodInfoPtr_Clone_Public_Static_Object_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x000FF018 File Offset: 0x000FD218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338619, XrefRangeEnd = 338625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Clone<T>(T obj) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = obj;
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
					ptr4 = ref obj;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.MethodInfoStoreGeneric_Clone_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x000FF0A4 File Offset: 0x000FD2A4
		[CallerCount(122)]
		[CachedScanResults(RefRangeStart = 338631, RefRangeEnd = 338753, XrefRangeStart = 338625, XrefRangeEnd = 338631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T DeepClone<T>(T obj) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = obj;
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
					ptr4 = ref obj;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.MethodInfoStoreGeneric_DeepClone_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x000FF130 File Offset: 0x000FD330
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 338759, RefRangeEnd = 338793, XrefRangeStart = 338753, XrefRangeEnd = 338759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T DeepClone<T>(T obj, bool createIfNull) where T : class, new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = obj;
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
					ptr4 = ref obj;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createIfNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.MethodInfoStoreGeneric_DeepClone_Public_Static_T_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x000FF1C8 File Offset: 0x000FD3C8
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 338800, RefRangeEnd = 338826, XrefRangeStart = 338793, XrefRangeEnd = 338800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> DeepClone<T>(Il2CppArrayBase<T> obj) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.MethodInfoStoreGeneric_DeepClone_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x000FF204 File Offset: 0x000FD404
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338832, RefRangeEnd = 338842, XrefRangeStart = 338826, XrefRangeEnd = 338832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> DeepClone<T>(List<T> obj) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.MethodInfoStoreGeneric_DeepClone_Public_Static_List_1_T_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x000FF248 File Offset: 0x000FD448
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 338857, RefRangeEnd = 338860, XrefRangeStart = 338842, XrefRangeEnd = 338857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<TKey, TValue> DeepClone<TKey, TValue>(Dictionary<TKey, TValue> dictionary) where TValue : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.MethodInfoStoreGeneric_DeepClone_Public_Static_Dictionary_2_TKey_TValue_Dictionary_2_TKey_TValue_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr3) : null;
			}
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x000FF28C File Offset: 0x000FD48C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338874, RefRangeEnd = 338875, XrefRangeStart = 338860, XrefRangeEnd = 338874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid CreateGuidHashSHA256(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.NativeMethodInfoPtr_CreateGuidHashSHA256_Public_Static_Guid_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x000FF2D0 File Offset: 0x000FD4D0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 338890, RefRangeEnd = 338901, XrefRangeStart = 338875, XrefRangeEnd = 338890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid CreateGuidHashSHA1(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.NativeMethodInfoPtr_CreateGuidHashSHA1_Public_Static_Guid_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x000FF314 File Offset: 0x000FD514
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 338912, RefRangeEnd = 338920, XrefRangeStart = 338901, XrefRangeEnd = 338912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid CreateHIDProductGuid(int vendorId, int productId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vendorId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.NativeMethodInfoPtr_CreateHIDProductGuid_Public_Static_Guid_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x000FF360 File Offset: 0x000FD560
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 338924, RefRangeEnd = 338930, XrefRangeStart = 338920, XrefRangeEnd = 338924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint Tick(uint counter)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref counter;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.NativeMethodInfoPtr_Tick_Public_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x000FF3A0 File Offset: 0x000FD5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338930, XrefRangeEnd = 338934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Tick(int counter)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref counter;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.NativeMethodInfoPtr_Tick_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x000FF3E0 File Offset: 0x000FD5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338934, XrefRangeEnd = 338938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint TickPrev(uint counter)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref counter;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.NativeMethodInfoPtr_TickPrev_Public_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x000FF420 File Offset: 0x000FD620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338938, XrefRangeEnd = 338944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TickPrev(int counter)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref counter;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.NativeMethodInfoPtr_TickPrev_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x000FF460 File Offset: 0x000FD660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338944, XrefRangeEnd = 338948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTickValid(uint tick)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tick;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.NativeMethodInfoPtr_IsTickValid_Public_Static_Boolean_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x000FF4A0 File Offset: 0x000FD6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338948, XrefRangeEnd = 338952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTickValid(int tick)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tick;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.NativeMethodInfoPtr_IsTickValid_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x000FF4E0 File Offset: 0x000FD6E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338958, RefRangeEnd = 338960, XrefRangeStart = 338952, XrefRangeEnd = 338958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTickNewer(uint tick1, uint tick2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tick1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tick2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.NativeMethodInfoPtr_IsTickNewer_Public_Static_Boolean_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x000FF52C File Offset: 0x000FD72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338960, XrefRangeEnd = 338966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTickNewer(int tick1, int tick2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tick1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tick2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.NativeMethodInfoPtr_IsTickNewer_Public_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003323 RID: 13091 RVA: 0x000FF578 File Offset: 0x000FD778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338966, XrefRangeEnd = 338972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTickNewerOrEqualTo(uint tick1, uint tick2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tick1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tick2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.NativeMethodInfoPtr_IsTickNewerOrEqualTo_Public_Static_Boolean_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x000FF5C4 File Offset: 0x000FD7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338972, XrefRangeEnd = 338978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTickNewerOrEqualTo(int tick1, int tick2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tick1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tick2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.NativeMethodInfoPtr_IsTickNewerOrEqualTo_Public_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x000FF610 File Offset: 0x000FD810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338978, XrefRangeEnd = 338986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long TickDifference(uint tick1, uint tick2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tick1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tick2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.NativeMethodInfoPtr_TickDifference_Public_Static_Int64_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x000FF65C File Offset: 0x000FD85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338986, XrefRangeEnd = 338994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TickDifference(int tick1, int tick2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tick1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tick2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.NativeMethodInfoPtr_TickDifference_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x000FF6A8 File Offset: 0x000FD8A8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 338994, RefRangeEnd = 339002, XrefRangeStart = 338994, XrefRangeEnd = 338994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Swap<T>(ref T a, ref T b)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MiscTools.MethodInfoStoreGeneric_Swap_Public_Static_Void_byref_T_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			a = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			b = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false));
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x000FF720 File Offset: 0x000FD920
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339030, RefRangeEnd = 339031, XrefRangeStart = 339002, XrefRangeEnd = 339030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToLongUnchecked(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.NativeMethodInfoPtr_ToLongUnchecked_Public_Static_Int64_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x000FF764 File Offset: 0x000FD964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339031, XrefRangeEnd = 339033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidGuid(string guid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscTools.NativeMethodInfoPtr_IsValidGuid_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x00011DB0 File Offset: 0x0000FFB0
		public MiscTools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x0600332B RID: 13099 RVA: 0x000FF7A8 File Offset: 0x000FD9A8
		// (set) Token: 0x0600332C RID: 13100 RVA: 0x00011DB9 File Offset: 0x0000FFB9
		public unsafe static uint ZxobDXMdplWguLNrVegYXtGQfOYC
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(MiscTools.NativeFieldInfoPtr_ZxobDXMdplWguLNrVegYXtGQfOYC, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MiscTools.NativeFieldInfoPtr_ZxobDXMdplWguLNrVegYXtGQfOYC, (void*)(&value));
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x0600332D RID: 13101 RVA: 0x000FF7C4 File Offset: 0x000FD9C4
		// (set) Token: 0x0600332E RID: 13102 RVA: 0x00011DC7 File Offset: 0x0000FFC7
		public unsafe static uint AmYJygYpbhYcLRGKhGmgLkvziXy
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(MiscTools.NativeFieldInfoPtr_AmYJygYpbhYcLRGKhGmgLkvziXy, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MiscTools.NativeFieldInfoPtr_AmYJygYpbhYcLRGKhGmgLkvziXy, (void*)(&value));
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x0600332F RID: 13103 RVA: 0x000FF7E0 File Offset: 0x000FD9E0
		// (set) Token: 0x06003330 RID: 13104 RVA: 0x00011DD5 File Offset: 0x0000FFD5
		public unsafe static uint geTWCpoeIUBQYIsGqNJsLTYInJbr
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(MiscTools.NativeFieldInfoPtr_geTWCpoeIUBQYIsGqNJsLTYInJbr, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MiscTools.NativeFieldInfoPtr_geTWCpoeIUBQYIsGqNJsLTYInJbr, (void*)(&value));
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06003331 RID: 13105 RVA: 0x000FF7FC File Offset: 0x000FD9FC
		// (set) Token: 0x06003332 RID: 13106 RVA: 0x00011DE3 File Offset: 0x0000FFE3
		public unsafe static int OEBnDMsbSfiuYcdcspgqRGfpXA
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MiscTools.NativeFieldInfoPtr_OEBnDMsbSfiuYcdcspgqRGfpXA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MiscTools.NativeFieldInfoPtr_OEBnDMsbSfiuYcdcspgqRGfpXA, (void*)(&value));
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06003333 RID: 13107 RVA: 0x000FF818 File Offset: 0x000FDA18
		// (set) Token: 0x06003334 RID: 13108 RVA: 0x00011DF1 File Offset: 0x0000FFF1
		public unsafe static int QESXUmkaDFZhTcvmFGopqNuVapZf
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MiscTools.NativeFieldInfoPtr_QESXUmkaDFZhTcvmFGopqNuVapZf, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MiscTools.NativeFieldInfoPtr_QESXUmkaDFZhTcvmFGopqNuVapZf, (void*)(&value));
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06003335 RID: 13109 RVA: 0x000FF834 File Offset: 0x000FDA34
		// (set) Token: 0x06003336 RID: 13110 RVA: 0x00011DFF File Offset: 0x0000FFFF
		public unsafe static int wBITsuUcSslrrxFpbaoIzmaeaik
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MiscTools.NativeFieldInfoPtr_wBITsuUcSslrrxFpbaoIzmaeaik, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MiscTools.NativeFieldInfoPtr_wBITsuUcSslrrxFpbaoIzmaeaik, (void*)(&value));
			}
		}

		// Token: 0x04002B8F RID: 11151
		private static readonly IntPtr NativeFieldInfoPtr_ZxobDXMdplWguLNrVegYXtGQfOYC;

		// Token: 0x04002B90 RID: 11152
		private static readonly IntPtr NativeFieldInfoPtr_AmYJygYpbhYcLRGKhGmgLkvziXy;

		// Token: 0x04002B91 RID: 11153
		private static readonly IntPtr NativeFieldInfoPtr_geTWCpoeIUBQYIsGqNJsLTYInJbr;

		// Token: 0x04002B92 RID: 11154
		private static readonly IntPtr NativeFieldInfoPtr_OEBnDMsbSfiuYcdcspgqRGfpXA;

		// Token: 0x04002B93 RID: 11155
		private static readonly IntPtr NativeFieldInfoPtr_QESXUmkaDFZhTcvmFGopqNuVapZf;

		// Token: 0x04002B94 RID: 11156
		private static readonly IntPtr NativeFieldInfoPtr_wBITsuUcSslrrxFpbaoIzmaeaik;

		// Token: 0x04002B95 RID: 11157
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Static_Object_Object_0;

		// Token: 0x04002B96 RID: 11158
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Static_T_T_0;

		// Token: 0x04002B97 RID: 11159
		private static readonly IntPtr NativeMethodInfoPtr_DeepClone_Public_Static_T_T_0;

		// Token: 0x04002B98 RID: 11160
		private static readonly IntPtr NativeMethodInfoPtr_DeepClone_Public_Static_T_T_Boolean_0;

		// Token: 0x04002B99 RID: 11161
		private static readonly IntPtr NativeMethodInfoPtr_DeepClone_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x04002B9A RID: 11162
		private static readonly IntPtr NativeMethodInfoPtr_DeepClone_Public_Static_List_1_T_List_1_T_0;

		// Token: 0x04002B9B RID: 11163
		private static readonly IntPtr NativeMethodInfoPtr_DeepClone_Public_Static_Dictionary_2_TKey_TValue_Dictionary_2_TKey_TValue_0;

		// Token: 0x04002B9C RID: 11164
		private static readonly IntPtr NativeMethodInfoPtr_CreateGuidHashSHA256_Public_Static_Guid_String_0;

		// Token: 0x04002B9D RID: 11165
		private static readonly IntPtr NativeMethodInfoPtr_CreateGuidHashSHA1_Public_Static_Guid_String_0;

		// Token: 0x04002B9E RID: 11166
		private static readonly IntPtr NativeMethodInfoPtr_CreateHIDProductGuid_Public_Static_Guid_Int32_Int32_0;

		// Token: 0x04002B9F RID: 11167
		private static readonly IntPtr NativeMethodInfoPtr_Tick_Public_Static_UInt32_UInt32_0;

		// Token: 0x04002BA0 RID: 11168
		private static readonly IntPtr NativeMethodInfoPtr_Tick_Public_Static_Int32_Int32_0;

		// Token: 0x04002BA1 RID: 11169
		private static readonly IntPtr NativeMethodInfoPtr_TickPrev_Public_Static_UInt32_UInt32_0;

		// Token: 0x04002BA2 RID: 11170
		private static readonly IntPtr NativeMethodInfoPtr_TickPrev_Public_Static_Int32_Int32_0;

		// Token: 0x04002BA3 RID: 11171
		private static readonly IntPtr NativeMethodInfoPtr_IsTickValid_Public_Static_Boolean_UInt32_0;

		// Token: 0x04002BA4 RID: 11172
		private static readonly IntPtr NativeMethodInfoPtr_IsTickValid_Public_Static_Boolean_Int32_0;

		// Token: 0x04002BA5 RID: 11173
		private static readonly IntPtr NativeMethodInfoPtr_IsTickNewer_Public_Static_Boolean_UInt32_UInt32_0;

		// Token: 0x04002BA6 RID: 11174
		private static readonly IntPtr NativeMethodInfoPtr_IsTickNewer_Public_Static_Boolean_Int32_Int32_0;

		// Token: 0x04002BA7 RID: 11175
		private static readonly IntPtr NativeMethodInfoPtr_IsTickNewerOrEqualTo_Public_Static_Boolean_UInt32_UInt32_0;

		// Token: 0x04002BA8 RID: 11176
		private static readonly IntPtr NativeMethodInfoPtr_IsTickNewerOrEqualTo_Public_Static_Boolean_Int32_Int32_0;

		// Token: 0x04002BA9 RID: 11177
		private static readonly IntPtr NativeMethodInfoPtr_TickDifference_Public_Static_Int64_UInt32_UInt32_0;

		// Token: 0x04002BAA RID: 11178
		private static readonly IntPtr NativeMethodInfoPtr_TickDifference_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04002BAB RID: 11179
		private static readonly IntPtr NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0;

		// Token: 0x04002BAC RID: 11180
		private static readonly IntPtr NativeMethodInfoPtr_ToLongUnchecked_Public_Static_Int64_Object_0;

		// Token: 0x04002BAD RID: 11181
		private static readonly IntPtr NativeMethodInfoPtr_IsValidGuid_Public_Static_Boolean_String_0;

		// Token: 0x02000445 RID: 1093
		private sealed class MethodInfoStoreGeneric_Clone_Public_Static_T_T_0<T>
		{
			// Token: 0x0400438C RID: 17292
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MiscTools.NativeMethodInfoPtr_Clone_Public_Static_T_T_0, Il2CppClassPointerStore<MiscTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000446 RID: 1094
		private sealed class MethodInfoStoreGeneric_DeepClone_Public_Static_T_T_0<T>
		{
			// Token: 0x0400438D RID: 17293
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MiscTools.NativeMethodInfoPtr_DeepClone_Public_Static_T_T_0, Il2CppClassPointerStore<MiscTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000447 RID: 1095
		private sealed class MethodInfoStoreGeneric_DeepClone_Public_Static_T_T_Boolean_0<T>
		{
			// Token: 0x0400438E RID: 17294
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MiscTools.NativeMethodInfoPtr_DeepClone_Public_Static_T_T_Boolean_0, Il2CppClassPointerStore<MiscTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000448 RID: 1096
		private sealed class MethodInfoStoreGeneric_DeepClone_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x0400438F RID: 17295
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MiscTools.NativeMethodInfoPtr_DeepClone_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<MiscTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000449 RID: 1097
		private sealed class MethodInfoStoreGeneric_DeepClone_Public_Static_List_1_T_List_1_T_0<T>
		{
			// Token: 0x04004390 RID: 17296
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MiscTools.NativeMethodInfoPtr_DeepClone_Public_Static_List_1_T_List_1_T_0, Il2CppClassPointerStore<MiscTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200044A RID: 1098
		private sealed class MethodInfoStoreGeneric_DeepClone_Public_Static_Dictionary_2_TKey_TValue_Dictionary_2_TKey_TValue_0<TKey, TValue>
		{
			// Token: 0x04004391 RID: 17297
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MiscTools.NativeMethodInfoPtr_DeepClone_Public_Static_Dictionary_2_TKey_TValue_Dictionary_2_TKey_TValue_0, Il2CppClassPointerStore<MiscTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200044B RID: 1099
		private sealed class MethodInfoStoreGeneric_Swap_Public_Static_Void_byref_T_byref_T_0<T>
		{
			// Token: 0x04004392 RID: 17298
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MiscTools.NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0, Il2CppClassPointerStore<MiscTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
