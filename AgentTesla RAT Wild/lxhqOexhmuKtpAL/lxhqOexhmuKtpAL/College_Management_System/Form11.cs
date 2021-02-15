using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using College_Management_System.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace College_Management_System
{
	// Token: 0x02000010 RID: 16
	[DesignerGenerated]
	public class Form11 : Form
	{
		// Token: 0x060000C3 RID: 195 RVA: 0x0000C32C File Offset: 0x0000A52C
		public Form11()
		{
			for (;;)
			{
				IL_CC:
				int num = 112;
				int num2 = -13;
				for (;;)
				{
					num2 ^= 56;
					for (;;)
					{
						IL_54:
						int num3 = Form2.uwpnsrqhswlmjh(34);
						int num4 = Form12.wsyoqrrjsoniul(58);
						for (;;)
						{
							num4 ^= 56;
							switch (num4 + 55)
							{
							case 0:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form11.get_lstCourses()).MethodHandle;
								num4 = -15;
								continue;
							}
							case 1:
								goto IL_54;
							case 2:
								switch (num3 + 50)
								{
								case 0:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form11.set_Label1(Label)).MethodHandle;
									num3 = -6;
									goto IL_22;
								}
								case 1:
									switch (num2 + 56)
									{
									case 0:
										goto IL_CC;
									case 1:
										switch (num)
										{
										case 60:
											this.con = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000514-0000-0010-8000-00AA006D2EA4")));
											num = 12;
											goto IL_11;
										case 61:
											num = 113;
											goto IL_11;
										case 62:
											this.rs = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000535-0000-0010-8000-00AA006D2EA4")));
											num = 115;
											goto IL_11;
										case 63:
										{
											RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form11.liwwdsgdvyigrg(object, EventArgs)).MethodHandle;
											num = 13;
											goto IL_11;
										}
										case 64:
											num = 14;
											goto IL_11;
										case 65:
											this.liwwdsgdvyigre();
											num = 15;
											goto IL_11;
										case 66:
											base.Load += this.liwwdsgdvyigrf;
											num = 114;
											goto IL_11;
										case 67:
											return;
										}
										goto Block_3;
									case 2:
										goto IL_108;
									case 3:
										break;
									default:
										num3 = Form12.wsyoqrrjsoniul(54);
										goto IL_22;
									}
									IL_11:
									num ^= 50;
									break;
								case 2:
									break;
								case 3:
									goto IL_C7;
								default:
									num4 = -14;
									continue;
								}
								num2 = Form7.mqgfoefwabbyeu(23);
								num3 = -27;
								goto IL_22;
							case 3:
								goto IL_22;
							}
							IL_3B:
							num4 = Form7.mqgfoefwabbyeu(21);
							continue;
							IL_22:
							num3 ^= 52;
							goto IL_3B;
						}
					}
					IL_C7:
					continue;
					Block_3:
					num2 = -16;
					continue;
					IL_108:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form11.liwwdsgdvyigrh(object, EventArgs)).MethodHandle;
					num2 = Form12.wsyoqrrjsoniul(53);
				}
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000C528 File Offset: 0x0000A728
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					for (;;)
					{
						IL_FD:
						int num = Form12.wsyoqrrjsoniul(58);
						int num2 = Form7.mqgfoefwabbyeu(19);
						for (;;)
						{
							num2 ^= 59;
							for (;;)
							{
								IL_A8:
								int num3 = Form12.wsyoqrrjsoniul(40);
								int num4 = 1;
								for (;;)
								{
									switch (num4 ^ 62)
									{
									case 60:
										switch (num3 + 60)
										{
										case 0:
											break;
										case 1:
										{
											RuntimeMethodHandle runtimeMethodHandle = methodof(Form11.set_cboSemester(ComboBox)).MethodHandle;
											num3 = -5;
											goto IL_4F;
										}
										case 2:
											switch (num2 + 56)
											{
											case 0:
												goto IL_FD;
											case 1:
												switch (num + 50)
												{
												case 0:
													this.components.Dispose();
													num = Form7.mqgfoefwabbyeu(27);
													goto IL_3E;
												case 1:
													num = -21;
													goto IL_3E;
												case 2:
												{
													RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form11.get_cboCourse()).MethodHandle;
													num = -22;
													goto IL_3E;
												}
												case 3:
													goto IL_19E;
												}
												goto Block_6;
											case 2:
												goto IL_13C;
											case 3:
												break;
											default:
												num3 = -6;
												goto IL_4F;
											}
											IL_3E:
											num ^= 58;
											break;
										case 3:
											goto IL_F8;
										default:
											num4 = 0;
											continue;
										}
										num2 = Form12.wsyoqrrjsoniul(53);
										num3 = Form12.wsyoqrrjsoniul(51);
										break;
									case 61:
									{
										RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form11..ctor()).MethodHandle;
										num4 = 3;
										continue;
									}
									case 62:
										goto IL_A8;
									case 63:
										break;
									default:
										IL_7A:
										num4 = 2;
										continue;
									}
									IL_4F:
									num3 ^= 62;
									goto IL_7A;
								}
							}
							IL_F8:
							continue;
							Block_6:
							num2 = -13;
							continue;
							IL_13C:
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form11.set_Label1(Label)).MethodHandle;
							num2 = -15;
						}
					}
					IL_19E:;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000C700 File Offset: 0x0000A900
		[DebuggerStepThrough]
		private void liwwdsgdvyigre()
		{
			for (;;)
			{
				int num = Form12.wsyoqrrjsoniul(54);
				for (;;)
				{
					num ^= 59;
					switch (num + 56)
					{
					case 0:
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(Form11.set_Label10(Label)).MethodHandle;
						num = -13;
						continue;
					}
					case 1:
						this.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
						base.Margin = new Padding(4, 4, 4, 4);
						base.Name = "Form11";
						this.Text = "Form11";
						base.ResumeLayout(false);
						num = -38;
						continue;
					case 2:
						this.cmdBack.Size = new Size(120, 34);
						this.cmdBack.TabIndex = 119;
						this.cmdBack.Text = "GO BACK";
						this.cmdBack.UseVisualStyleBackColor = false;
						this.cmdRegister.BackColor = Color.BlueViolet;
						this.cmdRegister.ForeColor = Color.White;
						num = -26;
						continue;
					case 3:
						this.cmdRemove.TabIndex = 115;
						this.cmdRemove.Text = "REMOVE";
						this.cmdRemove.UseVisualStyleBackColor = false;
						this.lstCourses.FormattingEnabled = true;
						this.lstCourses.ItemHeight = 16;
						num = -32;
						continue;
					case 4:
						this.cmdRegister.UseVisualStyleBackColor = false;
						for (;;)
						{
							int num2 = Form7.mqgfoefwabbyeu(27);
							for (;;)
							{
								num2 ^= 57;
								switch (num2 + 56)
								{
								case 0:
									num2 = -13;
									continue;
								case 1:
									num = -12;
									num2 = -19;
									continue;
								case 2:
									this.txtCounter.Name = "txtCounter";
									num2 = -24;
									continue;
								case 3:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form11.set_cmdBack(Button)).MethodHandle;
									num2 = -14;
									continue;
								}
								case 4:
									num2 = -9;
									continue;
								case 5:
									this.Label2.AutoSize = true;
									num2 = -16;
									continue;
								case 6:
									this.txtCounter.Location = new Point(223, 391);
									num2 = Form7.mqgfoefwabbyeu(23);
									continue;
								case 7:
									this.txtCounter.Size = new Size(100, 23);
									num2 = -23;
									continue;
								case 8:
									num2 = -22;
									continue;
								case 9:
									num2 = -10;
									continue;
								case 10:
									num2 = -12;
									continue;
								case 11:
									this.txtCounter.TabIndex = 117;
									num2 = -21;
									continue;
								case 12:
									goto IL_25B;
								}
								break;
							}
						}
						IL_25B:
						continue;
					case 5:
						this.Label2.Text = "No. of Courses Registered:";
						for (;;)
						{
							int num3 = Form7.mqgfoefwabbyeu(24);
							for (;;)
							{
								num3 ^= 49;
								switch (num3 + 56)
								{
								case 0:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form11.get_cboSemester()).MethodHandle;
									num3 = -7;
									continue;
								}
								case 1:
									num = -16;
									num3 = Form12.wsyoqrrjsoniul(56);
									continue;
								case 2:
									this.cmdRemove.Size = new Size(120, 36);
									num3 = -8;
									continue;
								case 3:
									this.cmdRemove.BackColor = Color.BlueViolet;
									num3 = -31;
									continue;
								case 4:
									num3 = -32;
									continue;
								case 5:
									num3 = -1;
									continue;
								case 6:
									this.cmdRemove.Location = new Point(450, 168);
									num3 = -3;
									continue;
								case 7:
									num3 = -6;
									continue;
								case 8:
									num3 = -30;
									continue;
								case 9:
									this.cmdRemove.Name = "cmdRemove";
									num3 = -29;
									continue;
								case 10:
									num3 = -5;
									continue;
								case 11:
									this.cmdRemove.ForeColor = Color.White;
									num3 = -4;
									continue;
								case 12:
									goto IL_385;
								}
								break;
							}
						}
						IL_385:
						continue;
					case 6:
						this.cmdAdd.Location = new Point(450, 105);
						this.cmdAdd.Name = "cmdAdd";
						this.cmdAdd.Size = new Size(120, 36);
						this.cmdAdd.TabIndex = 113;
						this.cmdAdd.Text = "ADD";
						num = -20;
						continue;
					case 7:
						this.Label2.ForeColor = Color.White;
						this.Label2.Location = new Point(38, 394);
						this.Label2.Name = "Label2";
						this.Label2.Size = new Size(179, 17);
						this.Label2.TabIndex = 116;
						num = -10;
						continue;
					case 8:
						this.Label3.AutoSize = true;
						this.Label3.ForeColor = Color.White;
						this.Label3.Location = new Point(38, 72);
						this.Label3.Name = "Label3";
						this.Label3.Size = new Size(66, 17);
						this.Label3.TabIndex = 120;
						num = -31;
						continue;
					case 9:
						base.Controls.Add(this.cmdAdd);
						for (;;)
						{
							int num4 = 2;
							for (;;)
							{
								switch (num4 ^ 62)
								{
								case 52:
									base.Controls.Add(this.cboSemester);
									num4 = 3;
									continue;
								case 53:
									base.Controls.Add(this.Label10);
									num4 = 8;
									continue;
								case 54:
									num4 = 10;
									continue;
								case 55:
								{
									RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form11.liwwdsgdvyigrf(object, EventArgs)).MethodHandle;
									num4 = 9;
									continue;
								}
								case 56:
									num4 = 1;
									continue;
								case 57:
									base.Controls.Add(this.cboCourse);
									num4 = 6;
									continue;
								case 58:
									num4 = 11;
									continue;
								case 59:
									num = -14;
									num4 = 126;
									continue;
								case 60:
									num4 = 0;
									continue;
								case 61:
									num4 = 7;
									continue;
								case 62:
									base.Controls.Add(this.Label11);
									num4 = 4;
									continue;
								case 63:
									base.Controls.Add(this.Label1);
									num4 = 5;
									continue;
								case 64:
									goto IL_5D2;
								}
								break;
							}
						}
						IL_5D2:
						continue;
					case 10:
						base.AutoScaleMode = AutoScaleMode.Font;
						this.BackColor = Color.SteelBlue;
						base.ClientSize = new Size(609, 449);
						base.Controls.Add(this.lblProgram);
						base.Controls.Add(this.Label3);
						base.Controls.Add(this.cmdBack);
						num = -30;
						continue;
					case 11:
						this.cboSemester.Name = "cboSemester";
						this.cboSemester.Size = new Size(236, 24);
						this.cboSemester.TabIndex = 110;
						this.cboCourse.FormattingEnabled = true;
						this.cboCourse.Location = new Point(157, 112);
						num = -37;
						continue;
					case 12:
						this.lblProgram.Location = new Point(154, 72);
						this.lblProgram.Name = "lblProgram";
						this.lblProgram.Size = new Size(51, 17);
						this.lblProgram.TabIndex = 121;
						this.lblProgram.Text = "Label4";
						num = -21;
						continue;
					case 13:
						this.cboSemester = new ComboBox();
						this.cboCourse = new ComboBox();
						this.Label1 = new Label();
						base.SuspendLayout();
						this.lblProgram.AutoSize = true;
						this.lblProgram.ForeColor = Color.White;
						num = -17;
						continue;
					case 14:
						this.cmdRemove = new Button();
						this.lstCourses = new ListBox();
						this.cmdAdd = new Button();
						this.Label11 = new Label();
						this.Label10 = new Label();
						num = -18;
						continue;
					case 15:
						this.cmdAdd.UseVisualStyleBackColor = false;
						this.Label11.AutoSize = true;
						this.Label11.ForeColor = Color.White;
						this.Label11.Location = new Point(38, 156);
						this.Label11.Name = "Label11";
						this.Label11.Size = new Size(72, 17);
						num = -25;
						continue;
					case 16:
						this.Label10.Name = "Label10";
						this.Label10.Size = new Size(57, 17);
						this.Label10.TabIndex = 111;
						this.Label10.Text = "Course:";
						this.cboSemester.FormattingEnabled = true;
						this.cboSemester.Location = new Point(157, 153);
						num = -24;
						continue;
					case 17:
						base.Controls.Add(this.cmdRegister);
						base.Controls.Add(this.txtCounter);
						base.Controls.Add(this.Label2);
						base.Controls.Add(this.cmdRemove);
						base.Controls.Add(this.lstCourses);
						num = -22;
						continue;
					case 18:
						this.Label3.Text = "Program:";
						this.cmdBack.BackColor = Color.BlueViolet;
						this.cmdBack.ForeColor = Color.White;
						this.cmdBack.Location = new Point(450, 302);
						this.cmdBack.Name = "cmdBack";
						num = Form7.mqgfoefwabbyeu(23);
						continue;
					case 19:
						this.lstCourses.Location = new Point(41, 195);
						this.lstCourses.Name = "lstCourses";
						this.lstCourses.Size = new Size(253, 180);
						this.lstCourses.TabIndex = 114;
						this.cmdAdd.BackColor = Color.BlueViolet;
						this.cmdAdd.ForeColor = Color.White;
						num = -11;
						continue;
					case 20:
						this.Label11.TabIndex = 112;
						this.Label11.Text = "Semester:";
						this.Label10.AutoSize = true;
						this.Label10.ForeColor = Color.White;
						this.Label10.Location = new Point(38, 115);
						num = -29;
						continue;
					case 21:
						this.cmdRegister.Location = new Point(450, 234);
						this.cmdRegister.Name = "cmdRegister";
						this.cmdRegister.Size = new Size(120, 36);
						this.cmdRegister.TabIndex = 118;
						this.cmdRegister.Text = "REGISTER";
						num = -9;
						continue;
					case 22:
						this.Label1.Name = "Label1";
						this.Label1.Size = new Size(346, 17);
						this.Label1.TabIndex = 108;
						this.Label1.Text = "Welcome to Semester Registration Menu for Students";
						base.AutoScaleDimensions = new SizeF(8f, 16f);
						num = -23;
						continue;
					case 23:
						this.lblProgram = new Label();
						this.Label3 = new Label();
						this.cmdBack = new Button();
						this.cmdRegister = new Button();
						this.txtCounter = new TextBox();
						this.Label2 = new Label();
						num = -19;
						continue;
					case 24:
						this.cboCourse.Name = "cboCourse";
						this.cboCourse.Size = new Size(236, 24);
						this.cboCourse.TabIndex = 109;
						this.Label1.AutoSize = true;
						this.Label1.ForeColor = Color.White;
						this.Label1.Location = new Point(137, 35);
						num = -27;
						continue;
					case 25:
						goto IL_C3F;
					}
					break;
				}
			}
			IL_C3F:
			base.PerformLayout();
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000D35B File Offset: 0x0000B55B
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000D369 File Offset: 0x0000B569
		internal virtual Label lblProgram { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000D376 File Offset: 0x0000B576
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000D384 File Offset: 0x0000B584
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0000D391 File Offset: 0x0000B591
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0000D3A0 File Offset: 0x0000B5A0
		internal virtual Button cmdBack
		{
			[CompilerGenerated]
			get
			{
				return this._cmdBack;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.liwwdsgdvyigrj);
				Button cmdBack = this._cmdBack;
				if (cmdBack != null)
				{
					cmdBack.Click -= value2;
				}
				this._cmdBack = value;
				cmdBack = this._cmdBack;
				if (cmdBack != null)
				{
					cmdBack.Click += value2;
				}
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000D40B File Offset: 0x0000B60B
		// (set) Token: 0x060000CD RID: 205 RVA: 0x0000D41C File Offset: 0x0000B61C
		internal virtual Button cmdRegister
		{
			[CompilerGenerated]
			get
			{
				return this._cmdRegister;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.liwwdsgdvyigri);
				Button cmdRegister = this._cmdRegister;
				if (cmdRegister != null)
				{
					cmdRegister.Click -= value2;
				}
				this._cmdRegister = value;
				cmdRegister = this._cmdRegister;
				if (cmdRegister != null)
				{
					cmdRegister.Click += value2;
				}
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000D487 File Offset: 0x0000B687
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0000D495 File Offset: 0x0000B695
		internal virtual TextBox txtCounter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000D4A2 File Offset: 0x0000B6A2
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x0000D4B0 File Offset: 0x0000B6B0
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000D4BD File Offset: 0x0000B6BD
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x0000D4CC File Offset: 0x0000B6CC
		internal virtual Button cmdRemove
		{
			[CompilerGenerated]
			get
			{
				return this._cmdRemove;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.liwwdsgdvyigrh);
				Button cmdRemove = this._cmdRemove;
				if (cmdRemove != null)
				{
					cmdRemove.Click -= value2;
				}
				this._cmdRemove = value;
				cmdRemove = this._cmdRemove;
				if (cmdRemove != null)
				{
					cmdRemove.Click += value2;
				}
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000D537 File Offset: 0x0000B737
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000D545 File Offset: 0x0000B745
		internal virtual ListBox lstCourses { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x0000D552 File Offset: 0x0000B752
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000D560 File Offset: 0x0000B760
		internal virtual Button cmdAdd
		{
			[CompilerGenerated]
			get
			{
				return this._cmdAdd;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.liwwdsgdvyigrg);
				Button cmdAdd = this._cmdAdd;
				if (cmdAdd != null)
				{
					cmdAdd.Click -= value2;
				}
				this._cmdAdd = value;
				cmdAdd = this._cmdAdd;
				if (cmdAdd != null)
				{
					cmdAdd.Click += value2;
				}
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000D5CB File Offset: 0x0000B7CB
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000D5D9 File Offset: 0x0000B7D9
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000D5E6 File Offset: 0x0000B7E6
		// (set) Token: 0x060000DB RID: 219 RVA: 0x0000D5F4 File Offset: 0x0000B7F4
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000D601 File Offset: 0x0000B801
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0000D60F File Offset: 0x0000B80F
		internal virtual ComboBox cboSemester { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000D61C File Offset: 0x0000B81C
		// (set) Token: 0x060000DF RID: 223 RVA: 0x0000D62A File Offset: 0x0000B82A
		internal virtual ComboBox cboCourse { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000D637 File Offset: 0x0000B837
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000D645 File Offset: 0x0000B845
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060000E2 RID: 226 RVA: 0x0000D654 File Offset: 0x0000B854
		private void liwwdsgdvyigrf(object @as, EventArgs at)
		{
			for (;;)
			{
				int num = Form7.mqgfoefwabbyeu(24);
				for (;;)
				{
					num ^= 52;
					switch (num + 54)
					{
					case 0:
						this.con.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\Joey\\Documents\\College.mdb; Persist Security Info = False", "", "", -1);
						num = -28;
						continue;
					case 1:
					{
						bool flag = Operators.ConditionalCompareObjectEqual(this.rs.Fields["Program"].Value, "Applied Computer Science", false);
						num = -27;
						continue;
					}
					case 2:
						this.lblProgram.Text = Conversions.ToString(this.rs.Fields["Program"].Value);
						num = -6;
						continue;
					case 3:
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(Form11.set_Label3(Label)).MethodHandle;
						num = -7;
						continue;
					}
					case 4:
						num = -1;
						continue;
					case 5:
						this.rs.Open("Select Program from StudentsProfile where AdmNo = '" + yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxh.txtUsername.Text + "'", this.con, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
						num = -26;
						continue;
					case 6:
						num = -5;
						continue;
					case 7:
					{
						bool flag;
						if (flag)
						{
							num = -25;
							continue;
						}
						goto IL_12B;
					}
					case 8:
						num = Form12.wsyoqrrjsoniul(40);
						continue;
					case 9:
						goto IL_128;
					}
					break;
				}
			}
			IL_128:
			bool flag2 = false;
			goto IL_12E;
			IL_12B:
			flag2 = true;
			IL_12E:
			if (!flag2)
			{
				this.cboCourse.Items.Add("C");
				for (;;)
				{
					int num2 = Form7.mqgfoefwabbyeu(23);
					for (;;)
					{
						num2 ^= 57;
						switch (num2 + 60)
						{
						case 0:
							this.cboCourse.Items.Add("Visual Basic");
							num2 = -4;
							continue;
						case 1:
							num2 = -16;
							continue;
						case 2:
						{
							RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form11.set_cmdRegister(Button)).MethodHandle;
							num2 = -1;
							continue;
						}
						case 3:
							this.cboCourse.Items.Add("Java");
							num2 = Form7.mqgfoefwabbyeu(31);
							continue;
						case 4:
							this.cboCourse.Items.Add("C++");
							num2 = -2;
							continue;
						case 5:
							goto IL_1F0;
						}
						break;
					}
				}
				IL_1F0:;
			}
			else
			{
				bool flag3 = Operators.ConditionalCompareObjectEqual(this.rs.Fields["Program"].Value, "Electrical Engineering", false);
				if (flag3)
				{
					this.cboCourse.Items.Add("Digital Electronics");
					for (;;)
					{
						int num3 = Form7.mqgfoefwabbyeu(31);
						for (;;)
						{
							num3 ^= 51;
							switch (num3 + 51)
							{
							case 0:
								num3 = -30;
								continue;
							case 1:
								this.cboCourse.Items.Add("Python Programming Language");
								num3 = -29;
								continue;
							case 2:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form11.set_cboCourse(ComboBox)).MethodHandle;
								num3 = Form2.uwpnsrqhswlmjh(42);
								continue;
							}
							case 3:
								this.cboCourse.Items.Add("Physics");
								num3 = -2;
								continue;
							case 4:
								goto IL_2C4;
							}
							break;
						}
					}
					IL_2C4:;
				}
				else
				{
					bool flag4 = Operators.ConditionalCompareObjectEqual(this.rs.Fields["Program"].Value, "Communication", false);
					if (flag4)
					{
						this.cboCourse.Items.Add("Public Relations");
						this.cboCourse.Items.Add("Cultural Studies");
						this.cboCourse.Items.Add("Electronic Media");
					}
					else
					{
						bool flag5 = Operators.ConditionalCompareObjectEqual(this.rs.Fields["Program"].Value, "International Relations", false);
						if (flag5)
						{
							this.cboCourse.Items.Add("Governmental Studies");
							this.cboCourse.Items.Add("Conflicts and Resolution");
							this.cboCourse.Items.Add("Treaties");
						}
						else
						{
							bool flag6 = Operators.ConditionalCompareObjectEqual(this.rs.Fields["Program"].Value, "Economics", false);
							if (flag6)
							{
								this.cboCourse.Items.Add("Introduction to Economics");
								this.cboCourse.Items.Add("Trade");
								this.cboCourse.Items.Add("Banking Services");
							}
						}
					}
				}
			}
			this.cboSemester.Items.Add("January 2017");
			for (;;)
			{
				int num4 = 12;
				for (;;)
				{
					switch (num4 ^ 53)
					{
					case 57:
						this.cboSemester.Items.Add("June 2017");
						num4 = 14;
						continue;
					case 58:
						this.counter = 0;
						num4 = 8;
						continue;
					case 59:
						this.cboSemester.Items.Add("August 2017");
						num4 = 15;
						continue;
					case 60:
					{
						RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form11.set_cmdBack(Button)).MethodHandle;
						num4 = 9;
						continue;
					}
					case 61:
						return;
					}
					break;
				}
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000DB7C File Offset: 0x0000BD7C
		private void liwwdsgdvyigrg(object au, EventArgs av)
		{
			bool flag = Operators.CompareString(this.cboCourse.Text, "", false) == 0;
			if (flag)
			{
				Interaction.MsgBox("Please Select a Course to Register.", MsgBoxStyle.Critical, null);
			}
			else
			{
				for (;;)
				{
					IL_142:
					int num = 14;
					int num2 = 0;
					for (;;)
					{
						num2 ^= 57;
						for (;;)
						{
							IL_AF:
							int num3 = Form12.wsyoqrrjsoniul(43);
							int num4 = 10;
							for (;;)
							{
								switch (num4 ^ 52)
								{
								case 59:
									switch (num3 + 49)
									{
									case 0:
										break;
									case 1:
									{
										RuntimeMethodHandle runtimeMethodHandle = methodof(Form11.set_txtCounter(TextBox)).MethodHandle;
										num3 = -21;
										goto IL_60;
									}
									case 2:
										checked
										{
											switch (num2)
											{
											case 54:
												goto IL_10C;
											case 55:
												switch (num)
												{
												case 51:
													this.txtCounter.Text = Conversions.ToString(this.counter);
													num = 12;
													goto IL_4F;
												case 52:
													this.counter++;
													num = 8;
													goto IL_4F;
												case 53:
													this.lstCourses.Items.Add(this.cboCourse.Text);
													num = 15;
													goto IL_4F;
												case 54:
												{
													RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form11.set_lblProgram(Label)).MethodHandle;
													num = 13;
													goto IL_4F;
												}
												case 55:
													num = 3;
													goto IL_4F;
												case 56:
													goto IL_1E3;
												}
												goto Block_4;
											case 56:
												goto IL_142;
											case 57:
												break;
											default:
												num3 = Form12.wsyoqrrjsoniul(58);
												goto IL_60;
											}
											IL_4F:
											num ^= 59;
											break;
										}
									case 3:
										goto IL_107;
									default:
										num4 = 8;
										continue;
									}
									num2 = 14;
									num3 = -23;
									break;
								case 60:
									goto IL_AF;
								case 61:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form11.set_cmdAdd(Button)).MethodHandle;
									num4 = 9;
									continue;
								}
								case 62:
									break;
								default:
									IL_8B:
									num4 = 15;
									continue;
								}
								IL_60:
								num3 ^= 59;
								goto IL_8B;
							}
						}
						IL_107:
						continue;
						IL_10C:
						RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form11.liwwdsgdvyigrg(object, EventArgs)).MethodHandle;
						num2 = 15;
						continue;
						Block_4:
						num2 = 1;
					}
				}
				IL_1E3:;
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000DD70 File Offset: 0x0000BF70
		private void liwwdsgdvyigrh(object aw, EventArgs ax)
		{
			for (;;)
			{
				IL_E5:
				int num = Form7.mqgfoefwabbyeu(21);
				int num2 = -22;
				for (;;)
				{
					num2 ^= 59;
					for (;;)
					{
						IL_39:
						int num3 = Form7.mqgfoefwabbyeu(29);
						int num4 = 7;
						for (;;)
						{
							switch (num4 ^ 49)
							{
							case 51:
								goto IL_39;
							case 52:
								switch (num3 + 55)
								{
								case 0:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form11.set_cboSemester(ComboBox)).MethodHandle;
									num3 = Form7.mqgfoefwabbyeu(27);
									goto IL_1C;
								}
								case 1:
									switch (num2 + 50)
									{
									case 0:
										switch (num + 62)
										{
										case 0:
											this.txtCounter.Text = Conversions.ToString(this.counter);
											num = -14;
											goto IL_0B;
										case 1:
											num = -16;
											goto IL_0B;
										case 2:
											num = -2;
											goto IL_0B;
										case 3:
											this.lstCourses.Items.Remove(RuntimeHelpers.GetObjectValue(this.lstCourses.SelectedItem));
											num = -11;
											goto IL_0B;
										case 4:
											checked
											{
												this.counter--;
												num = -12;
												goto IL_0B;
											}
										case 5:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form11.set_lstCourses(ListBox)).MethodHandle;
											num = Form7.mqgfoefwabbyeu(23);
											goto IL_0B;
										}
										case 6:
											return;
										}
										goto Block_2;
									case 1:
										goto IL_D7;
									case 2:
										goto IL_E5;
									case 3:
										break;
									default:
										num3 = -9;
										goto IL_1C;
									}
									IL_0B:
									num ^= 54;
									break;
								case 2:
									break;
								case 3:
									goto IL_A0;
								default:
									num4 = 2;
									continue;
								}
								num2 = Form7.mqgfoefwabbyeu(27);
								num3 = -16;
								goto IL_1C;
							case 53:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form11.get_Label2()).MethodHandle;
								num4 = 4;
								continue;
							}
							case 54:
								goto IL_1C;
							}
							IL_35:
							num4 = 5;
							continue;
							IL_1C:
							num3 ^= 60;
							goto IL_35;
						}
					}
					IL_A0:
					continue;
					Block_2:
					num2 = Form6.sbdifomqugmuko(57);
					continue;
					IL_D7:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form11.get_cboCourse()).MethodHandle;
					num2 = -12;
				}
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000DF40 File Offset: 0x0000C140
		private void liwwdsgdvyigri(object ay, EventArgs az)
		{
			bool flag = this.counter > 2;
			if (flag)
			{
				Interaction.MsgBox("Registration Not Allowed For More Than TWO Courses.", MsgBoxStyle.Critical, null);
			}
			else
			{
				bool flag2 = Operators.CompareString(this.cboSemester.Text, "", false) == 0;
				if (flag2)
				{
					Interaction.MsgBox("Please Select a Semester.", MsgBoxStyle.Critical, null);
				}
				else
				{
					for (;;)
					{
						int num = Form10.pdqangwdsoatqb(69);
						for (;;)
						{
							num ^= 67;
							switch (num + 61)
							{
							case 0:
								num = -122;
								continue;
							case 1:
								yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxf.Show();
								num = -128;
								continue;
							case 2:
							{
								bool flag3 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.rs.Fields["Program"].Value, "Applied Computer Science", false), Operators.CompareString(yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxc.lblSchool.Text, "Science, Engineering and Health", false) == 0));
								num = -118;
								continue;
							}
							case 3:
								num = -121;
								continue;
							case 4:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form11.get_cboCourse()).MethodHandle;
								num = -124;
								continue;
							}
							case 5:
								Interaction.MsgBox("Registration Successful.", MsgBoxStyle.Information, null);
								num = Form10.pdqangwdsoatqb(71);
								continue;
							case 6:
							{
								bool flag3;
								if (flag3)
								{
									num = -120;
									continue;
								}
								goto IL_189;
							}
							case 7:
								base.Hide();
								num = -123;
								continue;
							case 8:
								goto IL_186;
							}
							break;
						}
					}
					IL_186:
					bool flag4 = false;
					goto IL_18C;
					IL_189:
					flag4 = true;
					IL_18C:
					if (!flag4)
					{
						yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxc.txtStudents.Text = Conversions.ToString(Conversion.Val(yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxc.txtStudents.Text) + 1.0);
						for (;;)
						{
							int num2 = Form12.wsyoqrrjsoniul(40);
							for (;;)
							{
								num2 ^= 69;
								switch (num2 + 68)
								{
								case 0:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form11..ctor()).MethodHandle;
									num2 = -7;
									continue;
								}
								case 1:
									num2 = -5;
									continue;
								case 2:
									num2 = -6;
									continue;
								case 3:
									goto IL_215;
								}
								break;
							}
						}
						IL_215:;
					}
					else
					{
						bool flag5 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.rs.Fields["Program"].Value, "Electrical Engineering", false), Operators.CompareString(yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxc.lblSchool.Text, "Science, Engineering and Health", false) == 0));
						if (flag5)
						{
							yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxc.txtStudents.Text = Conversions.ToString(Conversion.Val(yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxc.txtStudents.Text) + 1.0);
							for (;;)
							{
								int num3 = 117;
								for (;;)
								{
									switch (num3 ^ 61)
									{
									case 72:
										num3 = 116;
										continue;
									case 73:
										num3 = 118;
										continue;
									case 74:
									{
										RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form11.liwwdsgdvyigrg(object, EventArgs)).MethodHandle;
										num3 = 119;
										continue;
									}
									case 75:
										goto IL_2FE;
									}
									break;
								}
							}
							IL_2FE:;
						}
						else
						{
							bool flag6 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.rs.Fields["Program"].Value, "Communication", false), Operators.CompareString(yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxc.lblSchool.Text, "Communication, Language and Performing Arts", false) == 0));
							if (flag6)
							{
								yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxc.txtStudents.Text = Conversions.ToString(Conversion.Val(yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxc.txtStudents.Text) + 1.0);
								for (;;)
								{
									int num4 = Form7.mqgfoefwabbyeu(25);
									for (;;)
									{
										num4 ^= 67;
										switch (num4 + 68)
										{
										case 0:
											num4 = -2;
											continue;
										case 1:
											num4 = Form2.uwpnsrqhswlmjh(42);
											continue;
										case 2:
										{
											RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form11.get_Label1()).MethodHandle;
											num4 = -3;
											continue;
										}
										case 3:
											goto IL_3F3;
										}
										break;
									}
								}
								IL_3F3:;
							}
							else
							{
								bool flag7 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.rs.Fields["Program"].Value, "International Relations", false), Operators.CompareString(yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxc.lblSchool.Text, "Arts and Humanities", false) == 0));
								if (flag7)
								{
									yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxc.txtStudents.Text = Conversions.ToString(Conversion.Val(yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxc.txtStudents.Text) + 1.0);
								}
								else
								{
									bool flag8 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.rs.Fields["Program"].Value, "Economics", false), Operators.CompareString(yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxc.lblSchool.Text, "Business and Economics", false) == 0));
									if (flag8)
									{
										yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxc.txtStudents.Text = Conversions.ToString(Conversion.Val(yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxc.txtStudents.Text) + 1.0);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000E4B4 File Offset: 0x0000C6B4
		private void liwwdsgdvyigrj(object ba, EventArgs bb)
		{
			for (;;)
			{
				IL_CC:
				int num = Form2.uwpnsrqhswlmjh(44);
				int num2 = 12;
				for (;;)
				{
					num2 ^= 72;
					for (;;)
					{
						IL_4D:
						int num3 = Form2.uwpnsrqhswlmjh(42);
						int num4 = -1;
						for (;;)
						{
							num4 ^= 59;
							switch (num4 + 63)
							{
							case 0:
								switch (num3 + 61)
								{
								case 0:
									switch (num2)
									{
									case 65:
										switch (num + 59)
										{
										case 0:
											num = -10;
											goto IL_0B;
										case 1:
											base.Hide();
											num = Form2.uwpnsrqhswlmjh(34);
											goto IL_0B;
										case 2:
											num = -11;
											goto IL_0B;
										case 3:
										{
											RuntimeMethodHandle runtimeMethodHandle = methodof(Form11.get_lstCourses()).MethodHandle;
											num = -12;
											goto IL_0B;
										}
										case 4:
											yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxf.Show();
											num = -7;
											goto IL_0B;
										case 5:
											return;
										}
										goto Block_2;
									case 66:
										goto IL_CC;
									case 67:
										goto IL_DC;
									case 68:
										break;
									default:
										num3 = -5;
										goto IL_1C;
									}
									IL_0B:
									num ^= 60;
									break;
								case 1:
									break;
								case 2:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form11.get_Label3()).MethodHandle;
									num3 = -6;
									goto IL_1C;
								}
								case 3:
									goto IL_9E;
								default:
									num4 = -7;
									continue;
								}
								num2 = 9;
								num3 = -7;
								goto IL_1C;
							case 1:
								goto IL_4D;
							case 2:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form11.get_Label11()).MethodHandle;
								num4 = -8;
								continue;
							}
							case 3:
								goto IL_1C;
							}
							IL_35:
							num4 = Form2.uwpnsrqhswlmjh(44);
							continue;
							IL_1C:
							num3 ^= 63;
							goto IL_35;
						}
					}
					IL_9E:
					continue;
					Block_2:
					num2 = 10;
					continue;
					IL_DC:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form11.get_Label10()).MethodHandle;
					num2 = 11;
				}
			}
		}

		// Token: 0x04000051 RID: 81
		private IContainer components;

		// Token: 0x04000060 RID: 96
		public Connection con;

		// Token: 0x04000061 RID: 97
		public Recordset rs;

		// Token: 0x04000062 RID: 98
		private int counter;
	}
}
