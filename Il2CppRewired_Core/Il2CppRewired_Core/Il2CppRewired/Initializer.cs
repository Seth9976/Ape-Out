using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x020000E5 RID: 229
	public sealed class Initializer : MonoBehaviour
	{
		// Token: 0x06001833 RID: 6195 RVA: 0x0008A1F0 File Offset: 0x000883F0
		// Note: this type is marked as 'beforefieldinit'.
		static Initializer()
		{
			Il2CppClassPointerStore<Initializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "Initializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Initializer>.NativeClassPtr);
			Initializer.NativeFieldInfoPtr__inputManagerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Initializer>.NativeClassPtr, "_inputManagerPrefab");
			Initializer.NativeFieldInfoPtr__destroySelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Initializer>.NativeClassPtr, "_destroySelf");
			Initializer.NativeMethodInfoPtr_get_inputManagerPrefab_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Initializer>.NativeClassPtr, 100669198);
			Initializer.NativeMethodInfoPtr_set_inputManagerPrefab_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Initializer>.NativeClassPtr, 100669199);
			Initializer.NativeMethodInfoPtr_get_destroySelf_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Initializer>.NativeClassPtr, 100669200);
			Initializer.NativeMethodInfoPtr_set_destroySelf_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Initializer>.NativeClassPtr, 100669201);
			Initializer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Initializer>.NativeClassPtr, 100669202);
			Initializer.NativeMethodInfoPtr_Initialize_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Initializer>.NativeClassPtr, 100669203);
			Initializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Initializer>.NativeClassPtr, 100669204);
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001834 RID: 6196 RVA: 0x0008A2D4 File Offset: 0x000884D4
		// (set) Token: 0x06001835 RID: 6197 RVA: 0x0008A314 File Offset: 0x00088514
		public unsafe GameObject inputManagerPrefab
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Initializer.NativeMethodInfoPtr_get_inputManagerPrefab_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Initializer.NativeMethodInfoPtr_set_inputManagerPrefab_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001836 RID: 6198 RVA: 0x0008A358 File Offset: 0x00088558
		// (set) Token: 0x06001837 RID: 6199 RVA: 0x0008A394 File Offset: 0x00088594
		public unsafe bool destroySelf
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Initializer.NativeMethodInfoPtr_get_destroySelf_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Initializer.NativeMethodInfoPtr_set_destroySelf_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x0008A3D4 File Offset: 0x000885D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278897, XrefRangeEnd = 278898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Initializer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x0008A408 File Offset: 0x00088608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279001, RefRangeEnd = 279002, XrefRangeStart = 278898, XrefRangeEnd = 279001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Initializer.NativeMethodInfoPtr_Initialize_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x0008A444 File Offset: 0x00088644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279002, XrefRangeEnd = 279005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Initializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Initializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Initializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x0000A13C File Offset: 0x0000833C
		public Initializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x0008A480 File Offset: 0x00088680
		// (set) Token: 0x0600183D RID: 6205 RVA: 0x0000A145 File Offset: 0x00008345
		public unsafe GameObject _inputManagerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Initializer.NativeFieldInfoPtr__inputManagerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Initializer.NativeFieldInfoPtr__inputManagerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x0600183E RID: 6206 RVA: 0x0008A4B0 File Offset: 0x000886B0
		// (set) Token: 0x0600183F RID: 6207 RVA: 0x0000A164 File Offset: 0x00008364
		public unsafe bool _destroySelf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Initializer.NativeFieldInfoPtr__destroySelf);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Initializer.NativeFieldInfoPtr__destroySelf)) = value;
			}
		}

		// Token: 0x04001522 RID: 5410
		private static readonly IntPtr NativeFieldInfoPtr__inputManagerPrefab;

		// Token: 0x04001523 RID: 5411
		private static readonly IntPtr NativeFieldInfoPtr__destroySelf;

		// Token: 0x04001524 RID: 5412
		private static readonly IntPtr NativeMethodInfoPtr_get_inputManagerPrefab_Public_get_GameObject_0;

		// Token: 0x04001525 RID: 5413
		private static readonly IntPtr NativeMethodInfoPtr_set_inputManagerPrefab_Public_set_Void_GameObject_0;

		// Token: 0x04001526 RID: 5414
		private static readonly IntPtr NativeMethodInfoPtr_get_destroySelf_Public_get_Boolean_0;

		// Token: 0x04001527 RID: 5415
		private static readonly IntPtr NativeMethodInfoPtr_set_destroySelf_Public_set_Void_Boolean_0;

		// Token: 0x04001528 RID: 5416
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001529 RID: 5417
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Boolean_0;

		// Token: 0x0400152A RID: 5418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
