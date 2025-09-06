# Contributing to Sluice

Thank you for your interest in contributing to the Sluice mod for Vintage Story! We welcome contributions from anyone who wants to help improve this project.

## How to Contribute

### Reporting Issues

If you find a bug or have a feature request, please:

1. **Check existing issues** first to avoid duplicates
2. **Create a new issue** with:
   - A clear, descriptive title
   - Detailed description of the problem or feature request
   - Steps to reproduce (for bugs)
   - Your Vintage Story version
   - Any relevant error messages or screenshots

### Submitting Pull Requests

We welcome pull requests for:

- Bug fixes
- New features
- Code improvements
- Documentation updates
- Translation improvements

#### Before You Start

1. **Fork the repository** to your own GitHub account
2. **Create a new branch** for your changes (e.g., `feature/new-feature` or `fix/bug-description`)
3. **Make your changes** following the coding standards below

#### Pull Request Process

1. **Test your changes** thoroughly
2. **Update documentation** if needed
3. **Write clear commit messages** describing what you changed
4. **Submit a pull request** with:
   - A clear title and description
   - Reference to any related issues
   - Screenshots or videos if applicable

## Development Setup

### Prerequisites

- Visual Studio 2019 or later (or Visual Studio Code)
- .NET 7.0 or later
- Vintage Story development environment
- Git

### Getting Started

1. **Clone your fork**:
   ```bash
   git clone https://github.com/yourusername/sluice.git
   cd sluice
   ```

2. **Open the solution** in Visual Studio or your preferred IDE

3. **Build the project** to ensure everything compiles correctly

4. **Test your changes** in Vintage Story

### File Structure

```
Sluice/
├── BlockEntities/          # Block entity classes
├── Blocks/                 # Block definitions
├── Config/                 # Configuration classes
├── Gui/                    # User interface components
├── assets/                 # Game assets (JSON files, textures, etc.)
│   └── sluice/
│       ├── blocktypes/     # Block type definitions
│       ├── lang/           # Language files
│       ├── recipes/        # Crafting recipes
│       └── shapes/         # 3D models
└── Network/                # Network communication (if needed)
```

## Areas for Contribution

### Code Improvements
- Performance optimizations
- Code refactoring
- Bug fixes
- New features

### Content
- New drop tables for different materials
- Additional sluice variants

### Documentation
- README improvements
- Code documentation
- User guides
- Tutorial content

### Translations
- Additional language support
- Translation improvements
- Localization testing

## Review Process

All pull requests will be reviewed by me. I may:

- Request changes or clarifications
- Ask for additional testing
- Suggest improvements
- Merge the changes if everything looks good

## Community Guidelines

- **Be respectful** and constructive in discussions
- **Help others** when you can
- **Follow the code of conduct** (see below)
- **Be patient** - This is a hobby project and I will get to your pull request when I can.

## Code of Conduct

This project follows a simple code of conduct:

- **Be respectful** of others' opinions and contributions
- **Be constructive** in feedback and discussions
- **Be inclusive** and welcoming to newcomers

## Questions?

If you have questions about contributing, feel free to:

- Open a discussion in the GitHub repository
- Ask questions in pull request comments
- Contact the maintainers directly

## Recognition

Contributors will be recognized in:

- The project's README file
- Release notes
- The mod's credits

Thank you for contributing to the Sluice mod! Your efforts help make this project better for everyone in the Vintage Story community.
