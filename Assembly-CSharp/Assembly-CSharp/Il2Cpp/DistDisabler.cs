using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000B6 RID: 182
	public class DistDisabler : MonoBehaviour
	{
		// Token: 0x060015FF RID: 5631 RVA: 0x00072520 File Offset: 0x00070720
		// Note: this type is marked as 'beforefieldinit'.
		static DistDisabler()
		{
			Il2CppClassPointerStore<DistDisabler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DistDisabler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DistDisabler>.NativeClassPtr);
			DistDisabler.NativeFieldInfoPtr_guards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistDisabler>.NativeClassPtr, "guards");
			DistDisabler.NativeFieldInfoPtr_farGuards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistDisabler>.NativeClassPtr, "farGuards");
			DistDisabler.NativeFieldInfoPtr_animals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistDisabler>.NativeClassPtr, "animals");
			DistDisabler.NativeFieldInfoPtr_closeGuards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistDisabler>.NativeClassPtr, "closeGuards");
			DistDisabler.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistDisabler>.NativeClassPtr, "me");
			DistDisabler.NativeFieldInfoPtr_listFilled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistDisabler>.NativeClassPtr, "listFilled");
			DistDisabler.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistDisabler>.NativeClassPtr, 100665140);
			DistDisabler.NativeMethodInfoPtr_ClearLists_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistDisabler>.NativeClassPtr, 100665141);
			DistDisabler.NativeMethodInfoPtr_Remove_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistDisabler>.NativeClassPtr, 100665142);
			DistDisabler.NativeMethodInfoPtr_MyStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistDisabler>.NativeClassPtr, 100665143);
			DistDisabler.NativeMethodInfoPtr_DisableAll_Public_Void_List_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistDisabler>.NativeClassPtr, 100665144);
			DistDisabler.NativeMethodInfoPtr_UpdateShit_Private_IEnumerator_List_1_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistDisabler>.NativeClassPtr, 100665145);
			DistDisabler.NativeMethodInfoPtr_GetQuad_Public_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistDisabler>.NativeClassPtr, 100665146);
			DistDisabler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistDisabler>.NativeClassPtr, 100665147);
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00072668 File Offset: 0x00070868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54839, XrefRangeEnd = 54841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistDisabler.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x0007269C File Offset: 0x0007089C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54846, RefRangeEnd = 54847, XrefRangeStart = 54841, XrefRangeEnd = 54846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearLists()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistDisabler.NativeMethodInfoPtr_ClearLists_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x000726D0 File Offset: 0x000708D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 54859, RefRangeEnd = 54863, XrefRangeStart = 54847, XrefRangeEnd = 54859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(Transform t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistDisabler.NativeMethodInfoPtr_Remove_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00072714 File Offset: 0x00070914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54863, XrefRangeEnd = 54913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistDisabler.NativeMethodInfoPtr_MyStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00072748 File Offset: 0x00070948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54913, XrefRangeEnd = 54944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableAll(List<Transform> shit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shit);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistDisabler.NativeMethodInfoPtr_DisableAll_Public_Void_List_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x0007278C File Offset: 0x0007098C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 54947, RefRangeEnd = 54949, XrefRangeStart = 54944, XrefRangeEnd = 54947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator UpdateShit(List<Transform> shit, int dist)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shit);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistDisabler.NativeMethodInfoPtr_UpdateShit_Private_IEnumerator_List_1_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x000727EC File Offset: 0x000709EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54949, XrefRangeEnd = 54953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetQuad(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistDisabler.NativeMethodInfoPtr_GetQuad_Public_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00072838 File Offset: 0x00070A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DistDisabler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DistDisabler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistDisabler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x0000FEF1 File Offset: 0x0000E0F1
		public DistDisabler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06001609 RID: 5641 RVA: 0x00072874 File Offset: 0x00070A74
		// (set) Token: 0x0600160A RID: 5642 RVA: 0x0000FEFA File Offset: 0x0000E0FA
		public unsafe List<Transform> guards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistDisabler.NativeFieldInfoPtr_guards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistDisabler.NativeFieldInfoPtr_guards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x000728A4 File Offset: 0x00070AA4
		// (set) Token: 0x0600160C RID: 5644 RVA: 0x0000FF19 File Offset: 0x0000E119
		public unsafe List<Transform> farGuards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistDisabler.NativeFieldInfoPtr_farGuards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistDisabler.NativeFieldInfoPtr_farGuards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x000728D4 File Offset: 0x00070AD4
		// (set) Token: 0x0600160E RID: 5646 RVA: 0x0000FF38 File Offset: 0x0000E138
		public unsafe List<Transform> animals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistDisabler.NativeFieldInfoPtr_animals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistDisabler.NativeFieldInfoPtr_animals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x00072904 File Offset: 0x00070B04
		// (set) Token: 0x06001610 RID: 5648 RVA: 0x0000FF57 File Offset: 0x0000E157
		public unsafe int closeGuards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistDisabler.NativeFieldInfoPtr_closeGuards);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistDisabler.NativeFieldInfoPtr_closeGuards)) = value;
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001611 RID: 5649 RVA: 0x0007292C File Offset: 0x00070B2C
		// (set) Token: 0x06001612 RID: 5650 RVA: 0x0000FF72 File Offset: 0x0000E172
		public unsafe static DistDisabler me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DistDisabler.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DistDisabler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DistDisabler.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x00072954 File Offset: 0x00070B54
		// (set) Token: 0x06001614 RID: 5652 RVA: 0x0000FF84 File Offset: 0x0000E184
		public unsafe bool listFilled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistDisabler.NativeFieldInfoPtr_listFilled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistDisabler.NativeFieldInfoPtr_listFilled)) = value;
			}
		}

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeFieldInfoPtr_guards;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeFieldInfoPtr_farGuards;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeFieldInfoPtr_animals;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeFieldInfoPtr_closeGuards;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeFieldInfoPtr_listFilled;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeMethodInfoPtr_ClearLists_Public_Void_0;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_Transform_0;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeMethodInfoPtr_MyStart_Public_Void_0;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeMethodInfoPtr_DisableAll_Public_Void_List_1_Transform_0;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShit_Private_IEnumerator_List_1_Transform_Int32_0;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr_GetQuad_Public_Int32_Vector2_0;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002F4 RID: 756
		[ObfuscatedName("DistDisabler+<UpdateShit>d__11")]
		public sealed class _UpdateShit_d__11 : global::Il2CppSystem.Object
		{
			// Token: 0x06004ED4 RID: 20180 RVA: 0x00120B70 File Offset: 0x0011ED70
			// Note: this type is marked as 'beforefieldinit'.
			static _UpdateShit_d__11()
			{
				Il2CppClassPointerStore<DistDisabler._UpdateShit_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DistDisabler>.NativeClassPtr, "<UpdateShit>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DistDisabler._UpdateShit_d__11>.NativeClassPtr);
				DistDisabler._UpdateShit_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistDisabler._UpdateShit_d__11>.NativeClassPtr, "<>1__state");
				DistDisabler._UpdateShit_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistDisabler._UpdateShit_d__11>.NativeClassPtr, "<>2__current");
				DistDisabler._UpdateShit_d__11.NativeFieldInfoPtr_shit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistDisabler._UpdateShit_d__11>.NativeClassPtr, "shit");
				DistDisabler._UpdateShit_d__11.NativeFieldInfoPtr_dist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistDisabler._UpdateShit_d__11>.NativeClassPtr, "dist");
				DistDisabler._UpdateShit_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistDisabler._UpdateShit_d__11>.NativeClassPtr, 100665148);
				DistDisabler._UpdateShit_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistDisabler._UpdateShit_d__11>.NativeClassPtr, 100665149);
				DistDisabler._UpdateShit_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistDisabler._UpdateShit_d__11>.NativeClassPtr, 100665150);
				DistDisabler._UpdateShit_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistDisabler._UpdateShit_d__11>.NativeClassPtr, 100665151);
				DistDisabler._UpdateShit_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistDisabler._UpdateShit_d__11>.NativeClassPtr, 100665152);
				DistDisabler._UpdateShit_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistDisabler._UpdateShit_d__11>.NativeClassPtr, 100665153);
			}

			// Token: 0x06004ED5 RID: 20181 RVA: 0x00120C64 File Offset: 0x0011EE64
			[CallerCount(0)]
			public unsafe _UpdateShit_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DistDisabler._UpdateShit_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistDisabler._UpdateShit_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004ED6 RID: 20182 RVA: 0x00120CAC File Offset: 0x0011EEAC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistDisabler._UpdateShit_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004ED7 RID: 20183 RVA: 0x00120CE0 File Offset: 0x0011EEE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54822, XrefRangeEnd = 54834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistDisabler._UpdateShit_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001CBE RID: 7358
			// (get) Token: 0x06004ED8 RID: 20184 RVA: 0x00120D1C File Offset: 0x0011EF1C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistDisabler._UpdateShit_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004ED9 RID: 20185 RVA: 0x00120D5C File Offset: 0x0011EF5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54834, XrefRangeEnd = 54839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistDisabler._UpdateShit_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CBF RID: 7359
			// (get) Token: 0x06004EDA RID: 20186 RVA: 0x00120D90 File Offset: 0x0011EF90
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistDisabler._UpdateShit_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004EDB RID: 20187 RVA: 0x0002E2F5 File Offset: 0x0002C4F5
			public _UpdateShit_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CBA RID: 7354
			// (get) Token: 0x06004EDC RID: 20188 RVA: 0x00120DD0 File Offset: 0x0011EFD0
			// (set) Token: 0x06004EDD RID: 20189 RVA: 0x0002E2FE File Offset: 0x0002C4FE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistDisabler._UpdateShit_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistDisabler._UpdateShit_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001CBB RID: 7355
			// (get) Token: 0x06004EDE RID: 20190 RVA: 0x00120DF8 File Offset: 0x0011EFF8
			// (set) Token: 0x06004EDF RID: 20191 RVA: 0x0002E319 File Offset: 0x0002C519
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistDisabler._UpdateShit_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistDisabler._UpdateShit_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CBC RID: 7356
			// (get) Token: 0x06004EE0 RID: 20192 RVA: 0x00120E28 File Offset: 0x0011F028
			// (set) Token: 0x06004EE1 RID: 20193 RVA: 0x0002E338 File Offset: 0x0002C538
			public unsafe List<Transform> shit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistDisabler._UpdateShit_d__11.NativeFieldInfoPtr_shit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistDisabler._UpdateShit_d__11.NativeFieldInfoPtr_shit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CBD RID: 7357
			// (get) Token: 0x06004EE2 RID: 20194 RVA: 0x00120E58 File Offset: 0x0011F058
			// (set) Token: 0x06004EE3 RID: 20195 RVA: 0x0002E357 File Offset: 0x0002C557
			public unsafe int dist
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistDisabler._UpdateShit_d__11.NativeFieldInfoPtr_dist);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistDisabler._UpdateShit_d__11.NativeFieldInfoPtr_dist)) = value;
				}
			}

			// Token: 0x04003397 RID: 13207
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003398 RID: 13208
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003399 RID: 13209
			private static readonly IntPtr NativeFieldInfoPtr_shit;

			// Token: 0x0400339A RID: 13210
			private static readonly IntPtr NativeFieldInfoPtr_dist;

			// Token: 0x0400339B RID: 13211
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400339C RID: 13212
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400339D RID: 13213
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400339E RID: 13214
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400339F RID: 13215
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040033A0 RID: 13216
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
