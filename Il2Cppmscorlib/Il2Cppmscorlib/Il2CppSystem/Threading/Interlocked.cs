using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000291 RID: 657
	public static class Interlocked : Object
	{
		// Token: 0x06002D0B RID: 11531 RVA: 0x000E7B0C File Offset: 0x000E5D0C
		// Note: this type is marked as 'beforefieldinit'.
		static Interlocked()
		{
			Il2CppClassPointerStore<Interlocked>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Interlocked");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interlocked>.NativeClassPtr);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Int32_byref_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670517);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Internal_Static_Int32_byref_Int32_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670518);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Object_byref_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670519);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Single_byref_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670520);
			Interlocked.NativeMethodInfoPtr_Decrement_Public_Static_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670521);
			Interlocked.NativeMethodInfoPtr_Increment_Public_Static_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670522);
			Interlocked.NativeMethodInfoPtr_Increment_Public_Static_Int64_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670523);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Int32_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670524);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Object_byref_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670525);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Single_byref_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670526);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Int64_byref_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670527);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670528);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Double_byref_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670529);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_T_byref_T_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670530);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Int64_byref_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670531);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670532);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Double_byref_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670533);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_T_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670534);
			Interlocked.NativeMethodInfoPtr_Read_Public_Static_Int64_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670535);
			Interlocked.NativeMethodInfoPtr_Add_Public_Static_Int32_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670536);
			Interlocked.NativeMethodInfoPtr_Add_Public_Static_Int64_byref_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670537);
			Interlocked.NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670538);
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x000E7CF4 File Offset: 0x000E5EF4
		[CallerCount(0)]
		public unsafe static int CompareExchange(ref int location1, int value, int comparand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparand;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Int32_byref_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x000E7D50 File Offset: 0x000E5F50
		[CallerCount(0)]
		public unsafe static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparand;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &succeeded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Internal_Static_Int32_byref_Int32_Int32_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x000E7DB8 File Offset: 0x000E5FB8
		[CallerCount(0)]
		public unsafe static Object CompareExchange(ref Object location1, Object value, Object comparand)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(location1);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparand);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Object_byref_Object_Object_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			location1 = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x000E7E38 File Offset: 0x000E6038
		[CallerCount(0)]
		public unsafe static float CompareExchange(ref float location1, float value, float comparand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparand;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Single_byref_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x000E7E94 File Offset: 0x000E6094
		[CallerCount(0)]
		public unsafe static int Decrement(ref int location)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Decrement_Public_Static_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D11 RID: 11537 RVA: 0x000E7ED4 File Offset: 0x000E60D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204682, RefRangeEnd = 204683, XrefRangeStart = 204682, XrefRangeEnd = 204682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Increment(ref int location)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Increment_Public_Static_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x000E7F14 File Offset: 0x000E6114
		[CallerCount(0)]
		public unsafe static long Increment(ref long location)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Increment_Public_Static_Int64_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x000E7F54 File Offset: 0x000E6154
		[CallerCount(0)]
		public unsafe static int Exchange(ref int location1, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Int32_byref_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x000E7FA0 File Offset: 0x000E61A0
		[CallerCount(0)]
		public unsafe static Object Exchange(ref Object location1, Object value)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(location1);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Object_byref_Object_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			location1 = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x000E8010 File Offset: 0x000E6210
		[CallerCount(0)]
		public unsafe static float Exchange(ref float location1, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Single_byref_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x000E805C File Offset: 0x000E625C
		[CallerCount(0)]
		public unsafe static long CompareExchange(ref long location1, long value, long comparand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparand;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Int64_byref_Int64_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x000E80B8 File Offset: 0x000E62B8
		[CallerCount(0)]
		public unsafe static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparand;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x000E8114 File Offset: 0x000E6314
		[CallerCount(0)]
		public unsafe static double CompareExchange(ref double location1, double value, double comparand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparand;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Double_byref_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x000E8170 File Offset: 0x000E6370
		[CallerCount(0)]
		public unsafe static T CompareExchange<T>(ref T location1, T value, T comparand) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(location1);
				ptr2 = &intPtr;
			}
			IntPtr* ptr3 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr5;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr4 = (ptr5 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr4) != null)
					{
						ptr5 = ref ptr4;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr4)))
						{
							ptr5 = IL2CPP.il2cpp_object_unbox(ref ptr4);
						}
					}
				}
				else
				{
					ptr5 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr5 = ref value;
			}
			*ptr3 = ref ptr5;
			IntPtr* ptr6 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr8;
			if (!typeof(T).IsValueType)
			{
				T t2 = comparand;
				if (!(t2 is string))
				{
					ref T ptr7 = (ptr8 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
					if ((ref ptr7) != null)
					{
						ptr8 = ref ptr7;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr7)))
						{
							ptr8 = IL2CPP.il2cpp_object_unbox(ref ptr7);
						}
					}
				}
				else
				{
					ptr8 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
				}
			}
			else
			{
				ptr8 = ref comparand;
			}
			*ptr6 = ref ptr8;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Interlocked.MethodInfoStoreGeneric_CompareExchange_Public_Static_T_byref_T_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			location1 = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x000E8284 File Offset: 0x000E6484
		[CallerCount(0)]
		public unsafe static long Exchange(ref long location1, long value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Int64_byref_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x000E82D0 File Offset: 0x000E64D0
		[CallerCount(0)]
		public unsafe static IntPtr Exchange(ref IntPtr location1, IntPtr value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x000E831C File Offset: 0x000E651C
		[CallerCount(0)]
		public unsafe static double Exchange(ref double location1, double value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Double_byref_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x000E8368 File Offset: 0x000E6568
		[CallerCount(0)]
		public unsafe static T Exchange<T>(ref T location1, T value) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(location1);
				ptr2 = &intPtr;
			}
			IntPtr* ptr3 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr5;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr4 = (ptr5 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr4) != null)
					{
						ptr5 = ref ptr4;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr4)))
						{
							ptr5 = IL2CPP.il2cpp_object_unbox(ref ptr4);
						}
					}
				}
				else
				{
					ptr5 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr5 = ref value;
			}
			*ptr3 = ref ptr5;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Interlocked.MethodInfoStoreGeneric_Exchange_Public_Static_T_byref_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			location1 = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x000E841C File Offset: 0x000E661C
		[CallerCount(0)]
		public unsafe static long Read(ref long location)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Read_Public_Static_Int64_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x000E845C File Offset: 0x000E665C
		[CallerCount(0)]
		public unsafe static int Add(ref int location1, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Add_Public_Static_Int32_byref_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x000E84A8 File Offset: 0x000E66A8
		[CallerCount(0)]
		public unsafe static long Add(ref long location1, long value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Add_Public_Static_Int64_byref_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x000E84F4 File Offset: 0x000E66F4
		[CallerCount(0)]
		public unsafe static void MemoryBarrier()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x0000F841 File Offset: 0x0000DA41
		public Interlocked(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400272A RID: 10026
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_Int32_byref_Int32_Int32_Int32_0;

		// Token: 0x0400272B RID: 10027
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Internal_Static_Int32_byref_Int32_Int32_Int32_byref_Boolean_0;

		// Token: 0x0400272C RID: 10028
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_Object_byref_Object_Object_Object_0;

		// Token: 0x0400272D RID: 10029
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_Single_byref_Single_Single_Single_0;

		// Token: 0x0400272E RID: 10030
		private static readonly IntPtr NativeMethodInfoPtr_Decrement_Public_Static_Int32_byref_Int32_0;

		// Token: 0x0400272F RID: 10031
		private static readonly IntPtr NativeMethodInfoPtr_Increment_Public_Static_Int32_byref_Int32_0;

		// Token: 0x04002730 RID: 10032
		private static readonly IntPtr NativeMethodInfoPtr_Increment_Public_Static_Int64_byref_Int64_0;

		// Token: 0x04002731 RID: 10033
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_Int32_byref_Int32_Int32_0;

		// Token: 0x04002732 RID: 10034
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_Object_byref_Object_Object_0;

		// Token: 0x04002733 RID: 10035
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_Single_byref_Single_Single_0;

		// Token: 0x04002734 RID: 10036
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_Int64_byref_Int64_Int64_Int64_0;

		// Token: 0x04002735 RID: 10037
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x04002736 RID: 10038
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_Double_byref_Double_Double_Double_0;

		// Token: 0x04002737 RID: 10039
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_T_byref_T_T_T_0;

		// Token: 0x04002738 RID: 10040
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_Int64_byref_Int64_Int64_0;

		// Token: 0x04002739 RID: 10041
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_0;

		// Token: 0x0400273A RID: 10042
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_Double_byref_Double_Double_0;

		// Token: 0x0400273B RID: 10043
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_T_byref_T_T_0;

		// Token: 0x0400273C RID: 10044
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_Int64_byref_Int64_0;

		// Token: 0x0400273D RID: 10045
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Int32_byref_Int32_Int32_0;

		// Token: 0x0400273E RID: 10046
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Int64_byref_Int64_Int64_0;

		// Token: 0x0400273F RID: 10047
		private static readonly IntPtr NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0;

		// Token: 0x020005F8 RID: 1528
		private sealed class MethodInfoStoreGeneric_CompareExchange_Public_Static_T_byref_T_T_T_0<T>
		{
			// Token: 0x0400445E RID: 17502
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_T_byref_T_T_T_0, Il2CppClassPointerStore<Interlocked>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005F9 RID: 1529
		private sealed class MethodInfoStoreGeneric_Exchange_Public_Static_T_byref_T_T_0<T>
		{
			// Token: 0x0400445F RID: 17503
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_T_byref_T_T_0, Il2CppClassPointerStore<Interlocked>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
