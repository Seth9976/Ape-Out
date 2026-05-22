using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200005D RID: 93
	[Serializable]
	public class MatchCollection : Object
	{
		// Token: 0x06000615 RID: 1557 RVA: 0x00028164 File Offset: 0x00026364
		// Note: this type is marked as 'beforefieldinit'.
		static MatchCollection()
		{
			Il2CppClassPointerStore<MatchCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "MatchCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr);
			MatchCollection.NativeFieldInfoPtr__regex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr, "_regex");
			MatchCollection.NativeFieldInfoPtr__matches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr, "_matches");
			MatchCollection.NativeFieldInfoPtr__done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr, "_done");
			MatchCollection.NativeFieldInfoPtr__input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr, "_input");
			MatchCollection.NativeFieldInfoPtr__beginning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr, "_beginning");
			MatchCollection.NativeFieldInfoPtr__length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr, "_length");
			MatchCollection.NativeFieldInfoPtr__startat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr, "_startat");
			MatchCollection.NativeFieldInfoPtr__prevlen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr, "_prevlen");
			MatchCollection.NativeFieldInfoPtr_infinite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr, "infinite");
			MatchCollection.NativeMethodInfoPtr__ctor_Internal_Void_Regex_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr, 100664231);
			MatchCollection.NativeMethodInfoPtr_GetMatch_Internal_Match_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr, 100664232);
			MatchCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr, 100664233);
			MatchCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr, 100664234);
			MatchCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr, 100664235);
			MatchCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Match_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr, 100664236);
			MatchCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr, 100664237);
			MatchCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr, 100664238);
			MatchCollection.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr, 100664240);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x000282FC File Offset: 0x000264FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 371010, RefRangeEnd = 371015, XrefRangeStart = 371006, XrefRangeEnd = 371010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchCollection(Regex regex, string input, int beginning, int length, int startat)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(input);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginning;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchCollection.NativeMethodInfoPtr__ctor_Internal_Void_Regex_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00028384 File Offset: 0x00026584
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 371018, RefRangeEnd = 371021, XrefRangeStart = 371015, XrefRangeEnd = 371018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match GetMatch(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchCollection.NativeMethodInfoPtr_GetMatch_Internal_Match_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x000283D0 File Offset: 0x000265D0
		public unsafe virtual int Count
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 371027, RefRangeEnd = 371033, XrefRangeStart = 371021, XrefRangeEnd = 371027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x0002840C File Offset: 0x0002660C
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(397)]
			[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x0002844C File Offset: 0x0002664C
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001E2 RID: 482
		public unsafe virtual Match this[int i]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371033, XrefRangeEnd = 371034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Match_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
				}
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x000284E0 File Offset: 0x000266E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371034, XrefRangeEnd = 371035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00028530 File Offset: 0x00026730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371035, XrefRangeEnd = 371038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00028570 File Offset: 0x00026770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371038, XrefRangeEnd = 371041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchCollection.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x000044B7 File Offset: 0x000026B7
		public MatchCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x000285AC File Offset: 0x000267AC
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x000044C0 File Offset: 0x000026C0
		public unsafe Regex _regex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchCollection.NativeFieldInfoPtr__regex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchCollection.NativeFieldInfoPtr__regex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x000285DC File Offset: 0x000267DC
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x000044DF File Offset: 0x000026DF
		public unsafe ArrayList _matches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchCollection.NativeFieldInfoPtr__matches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchCollection.NativeFieldInfoPtr__matches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x0002860C File Offset: 0x0002680C
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x000044FE File Offset: 0x000026FE
		public unsafe bool _done
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchCollection.NativeFieldInfoPtr__done);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchCollection.NativeFieldInfoPtr__done)) = value;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x00028634 File Offset: 0x00026834
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x00004519 File Offset: 0x00002719
		public unsafe string _input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchCollection.NativeFieldInfoPtr__input);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchCollection.NativeFieldInfoPtr__input), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x0002865C File Offset: 0x0002685C
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x00004538 File Offset: 0x00002738
		public unsafe int _beginning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchCollection.NativeFieldInfoPtr__beginning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchCollection.NativeFieldInfoPtr__beginning)) = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x00028684 File Offset: 0x00026884
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x00004553 File Offset: 0x00002753
		public unsafe int _length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchCollection.NativeFieldInfoPtr__length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchCollection.NativeFieldInfoPtr__length)) = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x000286AC File Offset: 0x000268AC
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x0000456E File Offset: 0x0000276E
		public unsafe int _startat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchCollection.NativeFieldInfoPtr__startat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchCollection.NativeFieldInfoPtr__startat)) = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x000286D4 File Offset: 0x000268D4
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x00004589 File Offset: 0x00002789
		public unsafe int _prevlen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchCollection.NativeFieldInfoPtr__prevlen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchCollection.NativeFieldInfoPtr__prevlen)) = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x000286FC File Offset: 0x000268FC
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x000045A4 File Offset: 0x000027A4
		public unsafe static int infinite
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MatchCollection.NativeFieldInfoPtr_infinite, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MatchCollection.NativeFieldInfoPtr_infinite, (void*)(&value));
			}
		}

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeFieldInfoPtr__regex;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeFieldInfoPtr__matches;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeFieldInfoPtr__done;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeFieldInfoPtr__input;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeFieldInfoPtr__beginning;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeFieldInfoPtr__length;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeFieldInfoPtr__startat;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeFieldInfoPtr__prevlen;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeFieldInfoPtr_infinite;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Regex_String_Int32_Int32_Int32_0;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr_GetMatch_Internal_Match_Int32_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Match_Int32_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
